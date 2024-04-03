using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface ISaleService
{
    IResult Add(Sale sale);
    IResult Update(Sale sale);
    IResult Delete(Sale sale);
    IDataResult<List<Sale>> GetAll();
    IDataResult<List<Sale>> GetAllByProduct(int productId);
    IDataResult<List<Sale>> GetAllByCustomer(int customerId);
    IDataResult<Sale> GetById(int id);
}
