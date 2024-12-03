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
             optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebShopDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
