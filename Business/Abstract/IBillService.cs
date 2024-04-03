using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface IBillService
{
    IResult Add(Bill bill);
    IResult Update(Bill bill);
    IResult Delete(Bill bill);
    IDataResult<List<Bill>> GetAll();
    IDataResult<List<Bill>> GetAllBySale(int saleId);
    IDataResult<Bill> GetById(int id);
}
