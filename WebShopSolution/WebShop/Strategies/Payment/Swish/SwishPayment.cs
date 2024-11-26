using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Strategies.Payment.Swish
{
    public class SwishPayment : IPaymentStrategy
    {
        public string ProcessPayment(double amount)
        {
            return $"Swish payment of {amount} processed.";
        }
    }
}
