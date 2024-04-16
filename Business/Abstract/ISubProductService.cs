using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface ISubProductService
{
    IResult Add(SubProduct subProduct);
    IResult Update(SubProduct subProduct);
    IResult Delete(SubProduct subProduct);
    IDataResult<List<SubProduct>> GetAll();
    IDataResult<List<SubProduct>> GetAllOrderByDate();
    IDataResult<SubProduct> GetById(int id);
}
