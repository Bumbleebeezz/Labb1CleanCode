using WebShop.Strategies.Payment.Swish;

namespace WebShopTests.Payment
{
    public class SwishPaymentProcessTests
    {
        [Fact]
        public void SwishPayment_ShouldReturnSuccessMessage()
        {
            // Arrange
            var swishPayment = new SwishPayment();

            // Act
            var result = swishPayment.ProcessPayment(100.0);

            // Assert
            Assert.Equal("Swish payment of 100 processed.", result);
        }
    }
}
