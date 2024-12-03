using Dataccess.Entities;
using Dataccess.Repositories.Orders;
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

            // Notifierar observatörer om att en ny order lagts till
            return Ok("Order added successfully."); // Return 200 with a message
        }

        // Endpoint för att updatera en order
        [HttpPut]
        public ActionResult UpdateOrder(int id)
        {
            if (id == null)
            {
                return BadRequest("Order cannot be null."); // Return 400 if input is null
            }
            // Notifierar observatörer om att produkten är uppdaterad
            return Ok("Order updated."); // Return 200 with a message
        }

        // Endpoint för att ta bort en order
        [HttpDelete]
        public ActionResult RemoveOrder(int id)
        {
            if (id == null)
            {
                return BadRequest("Order id cannot be null."); // Return 400 if input is null
            }
            return Ok("Order removed successfully."); // Return 200 with a message
        }
    }
}
