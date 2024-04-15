using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

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
    IDataResult<List<Sale>> GetAllByBillNumber(string billNumber);
    IDataResult<List<Sale>> GetAllByProductId(int productId);
    IDataResult<List<Sale>> GetAllBySubProductId(int subProductId);
    IDataResult<List<Sale>> GetAllBySubCustomerId(int customerId);
    IDataResult<List<SaleDto>> GetAllAsDto(List<Product> products, List<Customer> customers, List<SubProduct> subProducts);
}
