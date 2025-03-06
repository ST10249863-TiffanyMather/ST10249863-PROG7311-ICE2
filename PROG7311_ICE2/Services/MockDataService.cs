using PROG7311_ICE2.Models;

namespace PROG7311_ICE2.Services
{
    public class MockDataService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99m },
                new Product { Id = 2, Name = "Phone", Price = 499.99m },
                new Product { Id = 3, Name = "Headphones", Price = 199.99m }
            };
        }
    }
}
