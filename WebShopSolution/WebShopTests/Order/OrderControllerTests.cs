using Dataccess.Repositories.Orders;
using Dataccess.Repositories.Products;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Controllers;

namespace WebShopTests.Order
{
    public class OrderControllerTests
    {
        private readonly Mock<IOrderRepository> _mockOrderRepository;
        private readonly OrderController _controller;
    }
}
