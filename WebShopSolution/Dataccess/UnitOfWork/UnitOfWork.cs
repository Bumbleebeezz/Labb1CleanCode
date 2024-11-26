using Dataccess.Entities;
using Dataccess.Notifications;
using Dataccess.Repositories.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataccess.UnitOfWork
{
    public class UoW : IUnitOfWork
    {
        // Hämta produkter från repository
        public IProductRepository Products { get; private set; }

        private readonly ProductSubject _productSubject;

        // Konstruktor används för tillfället av Observer pattern
        public UoW(ProductSubject productSubject = null)
        {
            Products = null;

            // Om inget ProductSubject injiceras, skapa ett nytt
            _productSubject = productSubject ?? new ProductSubject();

            // Registrera standardobservatörer
            _productSubject.Attach(new EmailNotification());
        }

        public void NotifyProductAdded(Product product)
        {
            _productSubject.Notify(product);
        }
    }
}
