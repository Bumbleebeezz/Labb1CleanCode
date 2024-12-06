using Dataccess.Entities;

namespace WebShop.UnitOfWork
{
    public interface IUnitOfWork
    {
        void NotifyProductAdded(Product product); // Notifierar observatörer om ny produkt
    }
}
