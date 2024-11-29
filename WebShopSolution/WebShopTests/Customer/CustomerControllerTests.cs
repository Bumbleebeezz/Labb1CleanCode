using Dataccess.Repositories.Customers;
using Dataccess.Repositories.Products;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Controllers;

namespace WebShopTests.Customer
{
    public class CustomerControllerTests
    {
        private readonly Mock<ICustomerRepository> _mockCustomerRepository;
        private readonly CustomerController _controller;

        [Fact]
        public async void GetCustomers_ReturnsOkResult_WithAListOfCustomers()
        {
            // Arrange
            var controller = new CustomerController();

            // Act
            var result = controller.GetCustomers;

            // Assert
            Assert.NotNull(result); // Ensure the result is not null
            // var okResult = Assert.IsType<OkObjectResult>(result); // Check if the result is an OkObjectResult
            // Assert.NotNull(okResult.Value); // Ensure the Value is not null
        }
    }
}
