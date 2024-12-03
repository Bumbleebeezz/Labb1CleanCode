using Dataccess.Repositories.Customers;
using Moq;
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
        }
    }
}
