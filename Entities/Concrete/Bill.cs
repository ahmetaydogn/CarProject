using Core.Entities;

namespace Entities.Concrete;

public class Bill : IEntity
{
    public int BillId { get; set; }
    public int SaleId { get; set; }
    public DateTime SaleDate { get; set; }
    public decimal Price { get; set; }
}
