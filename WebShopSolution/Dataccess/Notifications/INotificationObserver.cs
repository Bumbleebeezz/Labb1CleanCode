using Dataccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataccess.Notifications
{
    // Gränssnitt för notifieringsobservatörer enligt Observer Pattern
    public interface INotificationObserver
    {
        void Update(Product product); // Metod som kallas när en ny produkt läggs till
    }
}
