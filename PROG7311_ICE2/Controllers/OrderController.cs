using Microsoft.AspNetCore.Mvc;
using PROG7311_ICE2.Models;
using PROG7311_ICE2.Services;

namespace PROG7311_ICE2.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PlaceOrder()
        {
            var order = new Order { Id = 1, ProductName = "Laptop", Price = 1500.00m };

            _orderService.ProcessOrder(order);

            ViewBag.Message = $"Order for {order.ProductName} has been placed.";
            return View("Index");
        }
    }
}
