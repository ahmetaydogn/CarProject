using Core.Entities;

namespace Entities.Concrete;

public class Product : IEntity
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public decimal MarketPrice { get; set; }
    public decimal SellPrice { get; set; }
    public byte VAT { get; set; }
    public short Quantity { get; set; }
    public decimal VATPrice { get; set; }
}
