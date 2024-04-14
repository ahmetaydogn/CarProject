using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface IBillService
{
    IResult Add(Bill bill);
    IResult Update(Bill bill);
    IResult Delete(Bill bill);
    IDataResult<List<Bill>> GetAll();
    IDataResult<List<string>> GetBillIDs();
    IDataResult<Bill> GetByBillNumber(string billNumber);
    IDataResult<List<BillDto>> GetAllAsDto(string billNumber, ISaleService saleService, List<Product> products, List<Customer> customers);
}
