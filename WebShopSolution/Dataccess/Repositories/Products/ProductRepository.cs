using Dataccess.DatabaseContext;
using Dataccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dataccess.Repositories.Products
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(WebShopDbContext context, DbSet<Product> dbSet) : base(context, dbSet) { }
       
    }
}
