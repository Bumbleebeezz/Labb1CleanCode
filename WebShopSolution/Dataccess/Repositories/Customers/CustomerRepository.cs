using Dataccess.DatabaseContext;
using Dataccess.Entities;
using Dataccess.Repositories.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataccess.Repositories.Customers
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(WebShopDbContext context, DbSet<Customer> dbSet) : base(context, dbSet)
        {
        }

        public void Add(Order item)
        {
            throw new NotImplementedException();
        }

        public void Update(Order item)
        {
            throw new NotImplementedException();
        }

        Order IRepository<Order>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Order> IRepository<Order>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
