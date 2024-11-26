
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Strategies.Payment;
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
            var paymentProcessor = new PaymentProcessor(swishPayment);

            // Act
            var result = paymentProcessor.ProcessPayment(100.0);

            // Assert
            Assert.Equal("Swish payment of 100 processed.", result);
        }
    }
}
