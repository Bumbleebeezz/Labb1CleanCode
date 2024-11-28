using Dataccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataccess.Repositories.Customers
{
    public interface ICustomerRepository : IRepository<Order>
    {
    }
}
