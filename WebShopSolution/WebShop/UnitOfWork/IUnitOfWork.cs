using Dataccess.Entities;

namespace WebShop.UnitOfWork
{
    public interface IUnitOfWork
    {
        // Repository för produkter
        // Sparar förändringar (om du använder en databas)
        void NotifyProductAdded(Product product); // Notifierar observatörer om ny produkt
    }
}
