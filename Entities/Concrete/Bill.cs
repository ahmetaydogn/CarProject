using Core.Entities;

namespace Entities.Concrete;

public class Bill : IEntity
{
    public string BillId { get; set; }
    public int SaleId { get; set; }
    public DateTime SaleDate { get; set; }
    public string Description { get; set; }
}
