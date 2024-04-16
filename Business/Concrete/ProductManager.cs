using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidator;
using Core.Utilities.Results;
using Core.Utilities.Validation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public IResult Add(Product product)
    {
        ValidationTool<Product>.Validate(new ProductValidator(), product);

        _productDal.Add(product);
        return new SuccessResult(Messages.ProductAdded);
    }

    public IResult Update(Product product)
    {
        ValidationTool<Product>.Validate(new ProductValidator(), product);

        _productDal.Update(product);
        return new SuccessResult(Messages.ProductUpdated);
    }

    public IResult Delete(Product product)
    {
        _productDal.Delete(product);
        return new SuccessResult(Messages.ProductDeleted);
    }

    public IDataResult<List<Product>> GetAll()
    {
        var result = _productDal.GetAll().ToList();
        return new SuccessDataResult<List<Product>>(result);
    }
    public IDataResult<List<Product>> GetAllOrderByDate()
    {
        var result = _productDal.GetAll().OrderBy(p => p.ProductAddDate).ToList();
        return new SuccessDataResult<List<Product>>(result);
    }

    public IDataResult<Product> GetById(int id)
    {
        var result = _productDal.Get(p => p.ProductId == id);
        return new SuccessDataResult<Product>(result);
    }
}
