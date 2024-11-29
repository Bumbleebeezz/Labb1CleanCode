using Dataccess.Entities;

namespace WebShop.Notifications
{
    // Gränssnitt för notifieringsobservatörer enligt Observer Pattern
    public interface INotificationObserver
    {
        void Update(Product product); // Metod som kallas när en ny produkt läggs till
        void Update(Customer customer); // Metod som kallas när en ny customer läggs till
        void Update(Order order); // Metod som kallas när en ny order läggs till
    }
}
