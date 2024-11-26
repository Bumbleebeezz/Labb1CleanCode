
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Strategies.Payment.CreditCard
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public string ProcessPayment(double amount)
        {
            return $"Credit card payment of {amount} processed.";
        }
    }
}
