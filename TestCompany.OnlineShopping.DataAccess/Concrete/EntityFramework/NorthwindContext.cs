using Microsoft.EntityFrameworkCore;
using TestCompany.OnlineShopping.Entities.Concrete;

namespace TestCompany.OnlineShopping.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           //Connection string yaz.
        }
        public DbSet<Product> Products { get; set; }
    }
}