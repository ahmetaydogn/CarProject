using Core.Entities;

namespace Entities.Concrete;

public class Customer : IEntity
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerSurname { get; set; }
    public string CustomerPhone { get; set; }
    public string CustomerAddress { get; set; }
    public string CustomerTaxNo { get; set; }
}
