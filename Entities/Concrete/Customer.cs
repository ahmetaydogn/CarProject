using Core.Entities;

namespace Entities.Concrete;

public class Customer : IEntity
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string TaxNo { get; set; }
}
