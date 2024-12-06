using Dataccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dataccess.DatabaseContext
{
    public class WebShopDbContext : DbContext
    {
        public WebShopDbContext() { }
        public WebShopDbContext(DbContextOptions<WebShopDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer("DefaultConnection");
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
