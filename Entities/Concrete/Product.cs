using Core.Entities;

namespace Entities.Concrete;

public class Product : IEntity
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string ProductModel { get; set; }
    public string ProductKM { get; set; }
    public string ProductColor { get; set; }
    public string ProductSituation { get; set; }
    public string ProductDescription { get; set; }
    public decimal MarketPrice { get; set; }
    public decimal SellPrice { get; set; }
    public short Quantity { get; set; }
    public string VAT { get; set; }
    public decimal VATPrice { get; set; }
    public string ExciseDuty { get; set; }
    public decimal ExciseDutyPrice { get; set; }
    public decimal Profit { get; set; }
}
