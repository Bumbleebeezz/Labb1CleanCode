using WebShop.Strategies.Payment.CreditCard;

namespace WebShopTests.Payment
{
    public class CreditCardPaymentProcessTests
    {
        [Fact]
        public void CreditCardPayment_ShouldReturnSuccessMessage()
        {
            // Arrange
            var creditCardPayment = new CreditCardPayment();

            // Act
            var result = creditCardPayment.ProcessPayment(100.0);

            // Assert
            Assert.Equal("Credit card payment of 100 processed.", result);
        }
    }
}
