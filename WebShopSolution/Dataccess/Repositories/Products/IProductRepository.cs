using Dataccess.Entities;

namespace Dataccess.Repositories.Products
{
    // Gränssnitt för produktrepositoryt enligt Repository Pattern
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetAll(); // Hämtar alla produkter
        void Add(Product product); // Lägger till en ny produkt
    }
}
