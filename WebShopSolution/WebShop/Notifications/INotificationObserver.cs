using Dataccess.Entities;

namespace WebShop.Notifications
{
    // Gränssnitt för notifieringsobservatörer enligt Observer Pattern
    public interface INotificationObserver
    {
        void Add(Product product); // Metod som kallas när en ny produkt läggs till
    }
}
