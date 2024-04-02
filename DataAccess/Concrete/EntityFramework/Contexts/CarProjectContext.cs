using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts;

public class CarProjectContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=CarProject;Trusted_Connection=true")
    }

    public DbSet<Product> Products { get; set; }
}
