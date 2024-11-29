using Dataccess.Entities;
using Dataccess.Repositories.Customers;
using Dataccess.Repositories.Orders;
using Dataccess.Repositories.Products;
using WebShop.Notifications;

namespace WebShop.UnitOfWork
{
    public class UoW : IUnitOfWork
    {
        // Hämta produkter från repository
        public IProductRepository Products { get; private set; }
        public ICustomerRepository Customers { get; private set; }
        public IOrderRepository Orders { get; private set; }

        private readonly ProductSubject _productSubject;

        // Konstruktor används för tillfället av Observer pattern
        public UoW(ProductSubject productSubject = null)
        {
            Products = null;
            Customers = null;
            Orders = null;

            // Om inget ProductSubject injiceras, skapa ett nytt
            _productSubject = productSubject ?? new ProductSubject();

            // Registrera standardobservatörer
            _productSubject.Attach(new EmailNotification());
        }

        public void NotifyProductAdded(Product product)
        {
            _productSubject.Notify(product);
        }

        public object GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
