using Dataccess.DatabaseContext;
using Dataccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dataccess.Repositories.Products
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(WebShopDbContext context, DbSet<Product> dbSet) : base(context, dbSet) { }
        public bool UpdateProductStock(Product product, int quantity)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            Add(product);
        }
    }
}
