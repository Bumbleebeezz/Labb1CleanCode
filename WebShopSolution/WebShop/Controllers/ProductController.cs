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

            var newProduct = new Product { Id = 1, Name = "New Product" };

            // Notifierar observat�rer om att en ny produkt har lagts till
            return Ok("Product added successfully."); // Return 200 with a message
        }

        // Endpoint f�r att updatera en produkt
        [HttpPut]
        [Route("id")]

        public ActionResult UpdateProduct(int id)
        {
            if (id == null)
            {
                return BadRequest("Product cannot be null."); // Return 400 if input is null
            }
            // Notifierar observat�rer om att produkten �r uppdaterad
            return Ok("Product updated."); // Return 200 with a message
        }

        // Endpoint f�r att ta bort en produkt
        [HttpDelete]
        public ActionResult RemoveProduct(int id)
        {
            if (id == null)
            {
                return BadRequest("Product id cannot be null."); // Return 400 if input is null
            }
            return Ok("Product removed successfully."); // Return 200 with a message
        }
    }
}
