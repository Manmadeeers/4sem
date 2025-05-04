using Newtonsoft.Json;
using SoftwareShop.Helpers;
using SoftwareShop.Models;
using SoftwareShop.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace SoftwareShop.ViewModels
{
    public class MainViewModel
    {
        private ProductsView _productsView;
        public ProductsView ProductsView
        {
            set { _productsView = value; }
        }

        private User _loggedUser;

        public User LoggedUser
        {
            get { return _loggedUser; }
            set { _loggedUser = value; }
        }

        private ObservableCollection<Product> _products;
        public ObservableCollection<Product> Products
        {
            get => _products;
            set { _products = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            Debug.WriteLine("MainViewModel created");
            LoadProducts();
            Debug.WriteLine($"Products loaded: {Products?.Count}");
        }

        private ICommand _unloginCommand;
        public ICommand UnloginCommand => _unloginCommand ??= new RelayCommand(Unlogin,CanUnlogin);

        private void Unlogin(object sender)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            _productsView.Close();
        }
        private bool CanUnlogin(object sender)
        {
            return true;
        }
        private void LoadProducts()
        {
            // Путь к JSON в папке проекта
            var jsonPath = "C:\\Users\\Manmade\\Desktop\\4sem\\OOP\\Lab code\\lab4-5\\SoftwareShop\\SoftwareShop\\Data\\products.json";
            if (File.Exists(jsonPath))
            {
                var json = File.ReadAllText(jsonPath);
                var list = JsonConvert.DeserializeObject<List<Product>>(json);
                Products = new ObservableCollection<Product>(list);
            }
            else
            {
                Products = new ObservableCollection<Product>();
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
