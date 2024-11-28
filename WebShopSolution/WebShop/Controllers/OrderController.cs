using Dataccess.Entities;
using Dataccess.Repositories.Orders;
using Dataccess.Repositories.Products;
using Microsoft.AspNetCore.Mvc;
using Moq;
using WebShop.UnitOfWork;

namespace WebShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly UoW _unitOfWork;

        public OrderController()
        {
        }

        // Endpoint för att hämta alla orders
        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetOrders()
        {
            // Fetch orders using repository pattern via Unit of Work
            var orders = _unitOfWork.GetAll();

            if (orders is null)
            {
                return NoContent(); // Return 204 if no orders found
            }
            // Behöver använda repository via Unit of Work för att hämta orders
            return Ok();
        }

        // Endpoint för att lägga till en ny order
        [HttpPost]
        public ActionResult AddOrder(Order order)
        {
            if (order == null)
            {
                return BadRequest("Order cannot be null."); // Return 400 if input is null
            }
            // Lägger till order via repository
            var mockRepo = new Mock<IOrderRepository>();
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            var newOrder = new Order { Id = 1, CustomerId = 1, Products = {5} };



            // Sparar förändringar

            // Notifierar observatörer om att en ny order lagts till

            return Ok("Order added successfully."); // Return 200 with a message
        }
    }
}
