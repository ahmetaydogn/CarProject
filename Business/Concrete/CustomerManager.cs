using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidator;
using Core.Utilities.Results;
using Core.Utilities.Validation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CustomerManager : ICustomerService
{
    private readonly ICustomerDal _customerDal;

    public CustomerManager(ICustomerDal customerDal)
    {
        _customerDal = customerDal;
    }


    public IResult Add(Customer customer)
    {
        ValidationTool<Customer>.Validate(new CustomerValidator(), customer);

        _customerDal.Add(customer);
        return new SuccessResult(Messages.ProductAdded);
    }

    public IResult Update(Customer customer)
    {
        ValidationTool<Customer>.Validate(new CustomerValidator(), customer);

        _customerDal.Update(customer);
        return new SuccessResult(Messages.ProductUpdated);
    }

    public IResult Delete(Customer customer)
    {
        _customerDal.Delete(customer);
        return new SuccessResult(Messages.ProductDeleted);
    }

    public IDataResult<Customer> Get(int id)
    {
        var result = _customerDal.Get(p => p.CustomerId == id);
        return new SuccessDataResult<Customer>(result);
    }

    public IDataResult<List<Customer>> GetAll()
    {
        var result = _customerDal.GetAll().ToList();
        return new SuccessDataResult<List<Customer>>(result);
    }

    public IDataResult<Customer> UniqueTaxNo(string taxNo)
    {
        throw new NotImplementedException();
    }
}
