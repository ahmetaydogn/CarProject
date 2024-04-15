using Core.Entities;

namespace Entities.Concrete;

public class SubProduct : IEntity
{
    public int SubProductId { get; set; }
    public string SubProductName { get; set; }
    public string SubProductDescription { get; set; }
    public decimal MarketPrice { get; set; }
    public decimal SellPrice { get; set; }
    public string VAT { get; set; }
    public short Quantity { get; set; }
    public decimal VATPrice { get; set; }
    public decimal Profit { get; set; }
}
