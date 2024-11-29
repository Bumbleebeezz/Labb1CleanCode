using Dataccess.Repositories.Customers;
using Dataccess.Repositories.Products;
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

            // Act

            // Assert
        }
    }
}
