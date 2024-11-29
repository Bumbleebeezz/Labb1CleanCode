using Dataccess.Entities;

namespace WebShop.Notifications
{
    // Subject som håller reda på observatörer och notifierar dem
    public class OrderSubject
    {
        // Lista över registrerade observatörer
        private readonly List<INotificationObserver> _observers = new();

        public void Attach(INotificationObserver observer)
        {
            // Lägg till en observatör
            _observers.Add(observer);
        }

        public void Detach(INotificationObserver observer)
        {
            // Ta bort en observatör
            _observers.Remove(observer);
        }

        public void Notify(Order order)
        {
            // Notifiera alla observatörer om en ny produkt
            foreach (var observer in _observers)
            {
                observer.Update(order);
            }
        }

    }
}
