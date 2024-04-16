using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidator;
using Core.Utilities.Results;
using Core.Utilities.Validation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete;

public class SubProductManager : ISubProductService
{
    private readonly ISubProductDal _subProductDal;

    public SubProductManager(ISubProductDal subProductDal)
    {
        _subProductDal = subProductDal;
    }

    public IResult Add(SubProduct subProduct)
    {
        ValidationTool<SubProduct>.Validate(new SubProductValidator(), subProduct);

        _subProductDal.Add(subProduct);
        return new SuccessResult();
    }

    public IResult Update(SubProduct subProduct)
    {
        ValidationTool<SubProduct>.Validate(new SubProductValidator(), subProduct);

        _subProductDal.Update(subProduct);
        return new SuccessResult();
    }
    
    public IResult Delete(SubProduct subProduct)
    {
        _subProductDal.Delete(subProduct);
        return new SuccessResult();
    }

    public IDataResult<List<SubProduct>> GetAll()
    {
        var result = _subProductDal.GetAll().ToList();
        return new SuccessDataResult<List<SubProduct>>(result);
    }

    public IDataResult<List<SubProduct>> GetAllOrderByDate()
    {
        var result = _subProductDal.GetAll().OrderBy(sP => sP.SubProductAddDate).ToList();
        return new SuccessDataResult<List<SubProduct>>(result);
    }

    public IDataResult<SubProduct> GetById(int id)
    {
        var result = _subProductDal.GetAll(p => p.SubProductId == id).FirstOrDefault();
        return new SuccessDataResult<SubProduct>(result);
    }
}
