using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidator;
using Core.Utilities.Results;
using Core.Utilities.Validation;
using DataAccess.Abstract;
using Entities.Concrete;

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
        var result = _saleDal.GetAll(p => p.CustomerId == customerId).ToList();
        return new SuccessDataResult<List<Sale>>(result);
    }

    public IDataResult<List<Sale>> GetAllByProduct(int productId)
    {
        var result = _saleDal.GetAll(p => p.ProductId == productId).ToList();
        return new SuccessDataResult<List<Sale>>(result);
    }

    public IDataResult<Sale> GetById(int id)
    {
        var result = _saleDal.Get(p => p.SaleId == id);
        return new SuccessDataResult<Sale>(result);
    }
}
