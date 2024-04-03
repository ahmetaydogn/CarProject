using Core.Entities;

namespace Entities.Concrete;

public  class Sale : IEntity
{
    public int SaleId { get; set; }
    public DateTime SaleDate { get; set; }
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public short Quantity { get; set; }
    public decimal Price { get; set; }
    public string PaymentMethod { get; set; }
    public string BillNumber { get; set; }
}
