using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidator;
using Core.Utilities.Results;
using Core.Utilities.Validation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class BillManager : IBillService
{
    private readonly IBillDal _billDal;
    public BillManager(IBillDal billDal)
    {
        _billDal = billDal;
    }

    public IResult Add(Bill bill)
    {
        ValidationTool<Bill>.Validate(new BillValidator(), bill);

        _billDal.Add(bill);
        return new SuccessResult(Messages.BillAdded);
    }

    public IResult Update(Bill bill)
    {
        ValidationTool<Bill>.Validate(new BillValidator(), bill);

        _billDal.Update(bill);
        return new SuccessResult(Messages.BillUpdated);
    }

    public IResult Delete(Bill bill)
    {
        _billDal.Delete(bill);
        return new SuccessResult(Messages.BillDeleted);
    }

    public IDataResult<List<Bill>> GetAll()
    {
        var result = _billDal.GetAll().ToList();
        return new SuccessDataResult<List<Bill>>(result);
    }

    public IDataResult<List<string>> GetBillIDs()
    {
        var result = _billDal.GetAll().Select(b => b.BillId).ToList();
        return new SuccessDataResult<List<string>>(result);
    }

    public IDataResult<Bill> GetByBillNumber(string number)
    {
        var result = _billDal.Get(b => b.BillId == number);
        return new SuccessDataResult<Bill>(result);
    }

    public IDataResult<List<BillDto>> GetAllAsDto(string billNumber, ISaleService saleService, List<Product> products, List<Customer> customers, List<SubProduct> subProducts)
    {
        var sales = saleService.GetAllByBillNumber(billNumber);
        var bill = GetByBillNumber(billNumber).Data;

        var productQuery = from sale in sales.Data
                    join customer in customers
                    on sale.CustomerId equals customer.CustomerId
                    join product in products
                    on sale.ProductId equals product.ProductId
                    select new BillDto
                    {
                        BillId = bill.BillId,
                        SaleId = sale.SaleId,
                        ProductId = product.ProductId,
                        SubProductId = null,
                        Profit = product.Profit,
                        CustomerId = customer.CustomerId,
                        SaleCustomerFullName = customer.CustomerName + " " + customer.CustomerSurname,
                        SaleCustomerPhone = customer.CustomerPhone,
                        SaleProductName = product.ProductName,
                        Quantity = sale.Quantity,
                        MarketPrice = product.MarketPrice,
                        SellPrice = product.SellPrice,
                        VATPrice = product.VATPrice,
                        SumPrice = sale.Quantity * product.SellPrice,
                        PaymentMethod = sale.PaymentMethod,
                        SaleDate = sale.SaleDate
                    };


        var subProductQuery = from sale in sales.Data
                           join customer in customers
                           on sale.CustomerId equals customer.CustomerId
                           join subproduct in subProducts
                           on sale.SubProductId equals subproduct.SubProductId
                           select new BillDto
                           {
                               BillId = bill.BillId,
                               SaleId = sale.SaleId,
                               ProductId = null,
                               SubProductId = subproduct.SubProductId,
                               Profit = subproduct.Profit,
                               CustomerId = customer.CustomerId,
                               SaleCustomerFullName = customer.CustomerName + " " + customer.CustomerSurname,
                               SaleCustomerPhone = customer.CustomerPhone,
                               SaleProductName = subproduct.SubProductName,
                               Quantity = sale.Quantity,
                               MarketPrice = subproduct.MarketPrice,
                               SellPrice = subproduct.SellPrice,
                               VATPrice = subproduct.VATPrice,
                               SumPrice = sale.Quantity * subproduct.SellPrice,
                               PaymentMethod = sale.PaymentMethod,
                               SaleDate = sale.SaleDate
                           };

        var merdegList = productQuery.ToList().Union(subProductQuery.ToList()).ToList();

        return new SuccessDataResult<List<BillDto>>(merdegList);
    }
}
