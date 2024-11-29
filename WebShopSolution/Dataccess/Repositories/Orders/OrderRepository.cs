using Dataccess.DatabaseContext;
using Dataccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dataccess.Repositories.Orders
{
    public class OrderRepository : Repository<Order>, IOrderRepository 
    {
        public OrderRepository(WebShopDbContext context, DbSet<Order> dbSet) : base(context, dbSet)
        {
        }
    }
}
