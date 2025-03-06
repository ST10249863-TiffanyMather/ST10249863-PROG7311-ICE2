using PROG7311_ICE2.Models;

namespace PROG7311_ICE2.Services
{
    public class OrderService : IOrderService
    {
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly INotificationService _notificationService;

        public OrderService(IPaymentProcessor paymentProcessor, INotificationService notificationService)
        {
            _paymentProcessor = paymentProcessor;
            _notificationService = notificationService;
        }

        public void ProcessOrder(Order order)
        {
            if (_paymentProcessor.ProcessPayment(order))
            {
                order.IsPaid = true;
                _notificationService.SendNotification($"Order for {order.ProductName} has been successfully processed.");
            }
        }
    }
}
