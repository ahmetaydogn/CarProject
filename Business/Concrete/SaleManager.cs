using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidator;
using Core.Utilities.Results;
using Core.Utilities.Validation;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class SaleManager : ISaleService
{
    private readonly ISaleDal _saleDal;

    public SaleManager(ISaleDal saleDal)
    {
        _saleDal = saleDal;
    }

    public IResult Add(Sale sale)
    {
        ValidationTool<Sale>.Validate(new SaleValidator(), sale);

        _saleDal.Add(sale);
        return new SuccessResult(Messages.SaleAdded);
    }

    public IResult Update(Sale sale)
    {
        ValidationTool<Sale>.Validate(new SaleValidator(), sale);

        _saleDal.Update(sale);
        return new SuccessResult(Messages.SaleUpdated);
    }

    public IResult Delete(Sale sale)
    {
        _saleDal.Delete(sale);
        return new SuccessResult(Messages.SaleDeleted);
    }

    public IDataResult<List<Sale>> GetAll()
    {
        var result = _saleDal.GetAll().ToList();
        return new SuccessDataResult<List<Sale>>(result);
    }

    public IDataResult<List<Sale>> GetAllByCustomer(int customerId)
    {
        var result = _saleDal.GetAll(s => s.CustomerId == customerId).ToList();
        return new SuccessDataResult<List<Sale>>(result);
    }

    public IDataResult<List<Sale>> GetAllByProduct(int productId)
    {
        var result = _saleDal.GetAll(s => s.ProductId == productId).ToList();
        return new SuccessDataResult<List<Sale>>(result);
    }

    public IDataResult<List<Sale>> GetAllByBillNumber(string billNumber)
    {
        var result = _saleDal.GetAll(s => s.BillNumber == billNumber).ToList();
        return new SuccessDataResult<List<Sale>>(result);
    }

    public IDataResult<Sale> GetById(int id)
    {
        var result = _saleDal.Get(p => p.SaleId == id);
        return new SuccessDataResult<Sale>(result);
    }

    public IDataResult<List<SaleDto>> GetAllAsDto(List<Product> products, List<Customer> customers)
    {
        var sales = GetAll();

        var query = from sale in sales.Data
                    join customer in customers
                    on sale.CustomerId equals customer.CustomerId
                    join product in products
                    on sale.ProductId equals product.ProductId
                    select new SaleDto
                    {
                        SaleId = sale.SaleId,
                        CustomerId = customer.CustomerId,
                        ProductId = product.ProductId,
                        CustomerFullName = customer.CustomerName + " " + customer.CustomerSurname,
                        CustomerPhone = customer.CustomerPhone,
                        ProductName = product.ProductName,
                        ProductModel = product.ProductModel,
                        SaleDate = sale.SaleDate,
                        Quantity = sale.Quantity,
                        Price = sale.Price,
                        Profit = sale.Price - (product.MarketPrice + product.VATPrice),
                        PaymentMethod = sale.PaymentMethod,
                        BillNumber = sale.BillNumber,
                    };

        return new SuccessDataResult<List<SaleDto>>(query.ToList());
    }
}