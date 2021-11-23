using System;

namespace MyAzureWebShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public string Color { get; set; }
        public DateTime Listed { get; set; }

    }
}
