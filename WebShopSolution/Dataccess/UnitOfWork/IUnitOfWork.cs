using Dataccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        // Repository för produkter
        // Sparar förändringar (om du använder en databas)
        void NotifyProductAdded(Product product); // Notifierar observatörer om ny produkt
    }
}
