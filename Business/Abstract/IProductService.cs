using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface IProductService
{
    IResult Add(Product product);
    IResult Update(Product product);
    IResult Delete(Product product);
    IDataResult<List<Product>> GetAll();
    IDataResult<Product> GetById(int id);
}
