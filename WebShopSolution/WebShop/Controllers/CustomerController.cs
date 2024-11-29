using Dataccess.Entities;
using Dataccess.Repositories.Customers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using WebShop.UnitOfWork;

namespace WebShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly UoW _unitOfWork;
        public CustomerController()
        {
        }
        // Endpoint för att hämta alla customer
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetCustomers()
        {
            // Fetch customers using repository pattern via Unit of Work
            var customers = _unitOfWork.GetAll();

            if (customers is null)
            {
                return NoContent(); // Return 204 if no customers found
            }
            // Behöver använda repository via Unit of Work för att hämta customers
            return Ok();
        }

        // Endpoint för att lägga till en ny customer
        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("Customert cannot be null."); // Return 400 if input is null
            }
            // Lägger till produkten via repository
            var mockRepo = new Mock<ICustomerRepository>();
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            var newCustomer = new Customer { Id = 1, FirstName = "Jack", LastName = "Smith", Email = "jack.smith@gmail.com"};

            // Sparar förändringar

            // Notifierar observatörer om att en ny produkt har lagts till

            return Ok("Customer added successfully."); // Return 200 with a message
        }

        // Endpoint för att updatera en customer
        [HttpPut]
        public ActionResult UpdateCustomer(int id)
        {
            if (id == null)
            {
                return BadRequest("Customer cannot be null."); // Return 400 if input is null
            }
            // Updatera produkten via repository

            // Sparar förändringar

            // Notifierar observatörer om att produkten är uppdaterad

            return Ok("Customer updated."); // Return 200 with a message
        }

        // Endpoint för att ta bort en customer
        [HttpDelete]
        public ActionResult RemoveCustomer(int id)
        {
            if (id == null)
            {
                return BadRequest("Customer id cannot be null."); // Return 400 if input is null
            }
            return Ok("Customer removed successfully."); // Return 200 with a message
        }
    }
}
