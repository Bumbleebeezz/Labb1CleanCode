using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Strategies.Payment
{
    public interface IPaymentStrategy
    {
        string ProcessPayment(double amount);
    }
}
