﻿using Dataccess.Entities;

namespace WebShop.Notifications
{
    public class EmailNotification : INotificationObserver
    {
        // En konkret observatör som skickar e-postmeddelanden

        public void Update(Product product)
        {
            // Här skulle du implementera logik för att skicka ett e-postmeddelande
            // För enkelhetens skull skriver vi ut till konsolen
            Console.WriteLine($"Email Notification: New Product added - {product.Name}");
        }
    }
}
