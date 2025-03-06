using PROG7311_ICE2.Models;

namespace PROG7311_ICE2.Services
{
    public interface IPaymentProcessor
    {
        bool ProcessPayment(Order order);
    }
}
