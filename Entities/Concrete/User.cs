using Core.Entities;

namespace Entities.Concrete;

public class User : IEntity
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string FullName { get; set; }
    public string Authority { get; set; }
    public string SSN { get; set; }
}
