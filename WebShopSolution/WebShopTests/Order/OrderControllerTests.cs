using Dataccess.Repositories.Orders;
using Moq;
using WebShop.Controllers;

namespace WebShopTests.Order
{
    public class OrderControllerTests
    {
        private readonly Mock<IOrderRepository> _mockOrderRepository;
        private readonly OrderController _controller;
    }
}
