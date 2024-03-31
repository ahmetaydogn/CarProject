using Core.Entities;

namespace Entities.Concrete;

public class Product : IEntity
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public decimal Vat { get; set; }
    public int Quantity { get; set; }
}
