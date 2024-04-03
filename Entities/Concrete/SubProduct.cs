using Core.Entities;

namespace Entities.Concrete;

public class SubProduct : IEntity
{
    public int SubProductId { get; set; }
    public string SubProductName { get; set; }
    public string SubProductDescription { get; set; }
    public decimal SubMarketPrice { get; set; }
    public decimal SubSellPrice { get; set; }
    public byte SubVAT { get; set; }
    public short SubQuantity { get; set; }
    public decimal SubVATPrice { get; set; }
}
