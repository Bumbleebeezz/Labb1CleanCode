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
