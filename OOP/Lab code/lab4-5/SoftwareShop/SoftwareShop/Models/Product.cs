
using SoftwareShop.ViewModels;
using System.Text.Json.Serialization;

namespace SoftwareShop.Models
{
    public class Product
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }

        [JsonIgnore]
        public MainViewModel model { get; set; }
    }
}
