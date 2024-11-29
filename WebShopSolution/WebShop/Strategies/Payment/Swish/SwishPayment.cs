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
