

namespace SoftwareShop.Models
{
    public class Product
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public string DetailedDescription { get; set; }

        public Product() { }
    }
}
