using Dataccess.Entities;
using Dataccess.Repositories.Products;
using Microsoft.AspNetCore.Mvc;
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

        // Endpoint för att hämta alla produkter
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            try
            {
                // Fetch products using the repository pattern via Unit of Work
                return Ok();
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                Console.WriteLine($"Error fetching products: {ex.Message}");

                // Return a generic error response
                return StatusCode(500, "An error occurred while fetching products.");
            }
        }

        // Endpoint för att lägga till en ny produkt
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            if (product == null)
            {
                return BadRequest("Product cannot be null."); // Return 400 if input is null
            }
            // Lägger till produkten via repository

            var newProduct = new Product { Id = 1, Name = "New Product" };

            // Notifierar observatörer om att en ny produkt har lagts till
            return Ok("Product added successfully."); // Return 200 with a message
        }
    }
}
