using Microsoft.EntityFrameworkCore;
using TestCompany.OnlineShopping.DataAccess.Concrete.EntityFramework.Mappings;
using TestCompany.OnlineShopping.Entities.Concrete;

namespace TestCompany.OnlineShopping.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           //Connection string yaz.
        }

        //DB bağlantısı için test yaz.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}