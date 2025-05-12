using SoftwareShop.Helpers;
using SoftwareShop.ViewModels;
using SoftwareShop.Views;
using System.Text.Json.Serialization;
using System.Windows;
using System.Windows.Input;

namespace SoftwareShop.Models
{
    public class Product
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        //public string DetailedDescription { get; set; }

        [JsonIgnore]
        public MainViewModel model { get; set; }
        [JsonIgnore]
        public ICommand MoreCommand { get; }

        public Product()
        {
            MoreCommand = new RelayCommand(OpenDetails);
        }



        private void OpenDetails(object obj)
        {
            var detailWindow = new MoreView(this);
            detailWindow.Owner = Application.Current.MainWindow;  
            detailWindow.ShowDialog();
        }
    }
}
