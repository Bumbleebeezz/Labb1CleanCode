using Dataccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dataccess.DatabaseContext
{
    public class WebShopDbContext : DbContext
    {
        public WebShopDbContext(DbContextOptions<WebShopDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

    }
}
