using Dataccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataccess.Notifications
{
    public class EmailNotification : INotificationObserver
    {
        // En konkret observatör som skickar e-postmeddelanden
        public void Update(Product product)
        {
            // Här skulle du implementera logik för att skicka ett e-postmeddelande
            // För enkelhetens skull skriver vi ut till konsolen
            Console.WriteLine($"Email Notification: New product added - {product.Name}");
        }
    }
}
