namespace WebShop.Strategies.Payment
{
    public class PaymentProcessor
    {
        private readonly IPaymentStrategy _paymentStrategy;

        public PaymentProcessor(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public string ProcessPayment(double amount)
        {
            return _paymentStrategy.ProcessPayment(amount);
        }
    }
}
