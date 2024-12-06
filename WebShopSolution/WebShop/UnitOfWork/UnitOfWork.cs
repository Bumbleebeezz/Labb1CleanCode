﻿using Dataccess.Entities;
using Dataccess.Repositories.Products;
using WebShop.Notifications;

namespace WebShop.UnitOfWork
{
    public class UoW : IUnitOfWork
    {
        // Hämta produkter från repository
        public IProductRepository Products { get; private set; }

        private readonly ProductSubject _productSubject;

        // Konstruktor används för tillfället av Observer pattern
        public UoW(ProductSubject productSubject)
        {
            _productSubject = productSubject ?? throw new ArgumentNullException(nameof(productSubject));

            // Initiera 
            //Products = Products ?? new List<Product>();
            //Customers = Customers ?? new List<Customer>();
            //Orders = Orders ?? new List<Order>();

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
