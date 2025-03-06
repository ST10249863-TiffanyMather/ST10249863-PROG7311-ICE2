using Microsoft.AspNetCore.Mvc;
using PROG7311_ICE2.Models;
using PROG7311_ICE2.Services;

namespace PROG7311_ICE2.Controllers
{
    public class OrderController : Controller
    {
        private readonly MockDataService _mockDataService;

        public OrderController()
        {
            _mockDataService = new MockDataService();
        }

        // Displays list of products
        public IActionResult Index()
        {
            var products = _mockDataService.GetProducts();
            return View(products);
        }

        // Displays the order form
        [HttpGet]
        public IActionResult PlaceOrder()
        {
            var products = _mockDataService.GetProducts();
            return View(products);
        }

        // Processes the order
        [HttpPost]
        public IActionResult PlaceOrder(string customerName, List<int> productIds)
        {
            var products = _mockDataService.GetProducts();
            var selectedProducts = products.Where(p => productIds.Contains(p.Id)).ToList();

            var order = new Order
            {
                CustomerName = customerName,
                Products = selectedProducts
            };

            return View("OrderSummary", order);
        }

        // Displays order summary
        public IActionResult OrderSummary(Order order)
        {
            return View(order);
        }
    }
}
