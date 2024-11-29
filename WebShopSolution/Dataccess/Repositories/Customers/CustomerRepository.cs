using Dataccess.DatabaseContext;
using Dataccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dataccess.Repositories.Customers
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(WebShopDbContext context, DbSet<Customer> dbSet) : base(context, dbSet)
        {
        }

        public void Add(Customer item)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer item)
        {
            throw new NotImplementedException();
        }

        Customer IRepository<Customer>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Customer> IRepository<Customer>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
