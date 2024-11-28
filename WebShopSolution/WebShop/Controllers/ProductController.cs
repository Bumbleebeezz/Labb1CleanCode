using Dataccess.Entities;
using Dataccess.Repositories.Products;
using Microsoft.AspNetCore.Mvc;
using Moq;
using WebShop.Notifications;
using WebShop.UnitOfWork;

namespace WebShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly UoW _unitOfWork;

        public ProductController()
        {
        }

        // Endpoint f�r att h�mta alla produkter
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            // Fetch products using repository pattern via Unit of Work
            var products = _unitOfWork.GetAll();

            if (products is null)
            {
                return NoContent(); // Return 204 if no products found
            }
            // Beh�ver anv�nda repository via Unit of Work f�r att h�mta produkter
            return Ok();
        }

        // Endpoint f�r att l�gga till en ny produkt
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            if (product == null)
            {
                return BadRequest("Product cannot be null."); // Return 400 if input is null
            }
            // L�gger till produkten via repository
            var mockRepo = new Mock<IProductRepository>();
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            var newProduct = new Product { Id = 1, Name = "New Product" };

            

            // Sparar f�r�ndringar

            // Notifierar observat�rer om att en ny produkt har lagts till

            return Ok("Product added successfully."); // Return 200 with a message
        }
    }
}
