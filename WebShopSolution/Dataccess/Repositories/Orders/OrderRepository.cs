using Dataccess.DatabaseContext;
using Dataccess.Entities;
using Dataccess.Repositories.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataccess.Repositories.Orders
{ 
    public class OrderRepository : Repository<Order>, IOrderRepository 
    {
        public OrderRepository(WebShopDbContext context, DbSet<Order> dbSet) : base(context, dbSet)
        {
        }
    }
}
