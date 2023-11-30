using Microsoft.EntityFrameworkCore;
using ProductWebMVC.Models;

namespace ProductWebMVC.Data
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options):
            base(options){ }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new Product { Id = 1, year = "senior", name = "sam huseman", bd = "10/06/2000", program = "IT" },
                 new Product { Id = 2, year = "junior", name = "kyle doersam", bd = "02/08/2003", program = "IT" },
                 new Product { Id = 3, year = "senior", name = "sam huseman", bd = "10/06/2000", program = "IT" },
                 new Product { Id = 4, year = "sophomore", name = "emma danner", bd = "04/09/2004", program = "IT" }
                 new Product { Id = 4, year = "junior", name = "amir rai", bd = "07/19/2002", program = "IT" }
                  
                );
        }
    }
}
