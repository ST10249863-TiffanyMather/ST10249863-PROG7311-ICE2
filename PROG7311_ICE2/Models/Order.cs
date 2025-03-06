namespace PROG7311_ICE2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public decimal TotalAmount => Products.Sum(p => p.Price);
    }
}
