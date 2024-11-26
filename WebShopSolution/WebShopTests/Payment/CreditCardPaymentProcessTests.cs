
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.Strategies.Payment;
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
            var paymentProcessor = new PaymentProcessor(creditCardPayment);

            // Act
            var result = paymentProcessor.ProcessPayment(100.0);

            // Assert
            Assert.Equal("Credit card payment of 100 processed.", result);
        }
    }
}
