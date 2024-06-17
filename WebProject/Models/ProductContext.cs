using Microsoft.EntityFrameworkCore;

namespace WebProject.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }   
}
