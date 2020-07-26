using Microsoft.EntityFrameworkCore;
using ShopSolution.Data.Entities;

namespace ShopSolution.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
