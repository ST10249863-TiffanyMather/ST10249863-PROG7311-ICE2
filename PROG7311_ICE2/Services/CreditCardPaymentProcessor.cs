using PROG7311_ICE2.Models;

namespace PROG7311_ICE2.Services
{
    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public bool ProcessPayment(Order order)
        {
            Console.WriteLine($"Processing credit card payment for {order.ProductName}, Amount: {order.Price}");
            return true;
        }
    }
}
