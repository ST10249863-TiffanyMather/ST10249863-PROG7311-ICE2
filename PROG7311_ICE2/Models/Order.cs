namespace PROG7311_ICE2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public bool IsPaid { get; set; }
    }
}
