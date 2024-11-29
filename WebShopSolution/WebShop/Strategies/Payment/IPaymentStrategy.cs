namespace WebShop.Strategies.Payment
{
    public interface IPaymentStrategy
    {
        string ProcessPayment(double amount);
    }
}
