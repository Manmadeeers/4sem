using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using SoftwareShop.Helpers;
using SoftwareShop.Models;
using SoftwareShop.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Windows;
using System.Windows.Input;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace SoftwareShop.ViewModels
{
    public class MainViewModel
    {
        public Visibility ItemsDeleteVisibility;
        
        private ProductsView _productsView;
        public ProductsView ProductsView
        {
            get { return  _productsView; }
            set { _productsView = value; }
        }

        public AddView AddView;

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
            set { _products = value; OnPropertyChanged(nameof(Products));}
        }
        private ObservableCollection<Product> _allProducts;
        public ObservableCollection<Product> AllProducts
        {
            get => _allProducts;
            set { _allProducts = value;OnPropertyChanged(nameof(AllProducts)); }
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
            //if (ProductsView.logged.IsAdmin)
            //{
            //    this.ItemsDeleteVisibility = Visibility.Visible;
            //}
            //else
            //{
            //    this.ItemsDeleteVisibility = Visibility.Hidden;
            //}
            // Путь к JSON в папке проекта
            var jsonPath = "C:\\Users\\Manmade\\Desktop\\4sem\\OOP\\Lab code\\lab4-5\\SoftwareShop\\SoftwareShop\\Data\\products.json";
            if (File.Exists(jsonPath))
            {
                var json = File.ReadAllText(jsonPath);
                var list = JsonConvert.DeserializeObject<List<Product>>(json);
                Products = new ObservableCollection<Product>(list);
                foreach(var prod in Products)
                {
                    prod.model = this;
                }
            }
            else
            {
                Products = new ObservableCollection<Product>();
            }
            AllProducts = new ObservableCollection<Product>(Products);
           
        }


        private string searchText;
        public string SearchText
        {
            get => searchText;
            set
            {
                if (searchText != value)
                {
                    searchText = value;
                    OnPropertyChanged(nameof(SearchText));
                }
            }
        }

        private ICommand _searchCommand;
        public ICommand SearchCommand => _searchCommand ??= new RelayCommand(Search,CanSearch);


        private void Search(object parameter)
        {


            if (string.IsNullOrWhiteSpace(searchText))
            {
                Products.Clear();
                foreach(var product in AllProducts)
                {
                    Products.Add(product);
                }
                Debug.WriteLine("Emptysearch field");
            }
            else
            {
                var filtered = AllProducts.Where(p =>!string.IsNullOrEmpty(p.Name) &&p.Name.IndexOf(SearchText, StringComparison.OrdinalIgnoreCase) >= 0);
                Debug.WriteLine($"found {filtered.Count()}");
                Products.Clear();
                foreach (var product in filtered)
                {
                    Products.Add(product);
                }
                Debug.WriteLine($"{searchText} was entered");
                Debug.WriteLine($"{Products.Count} was added as filtered");
                
            }
            
        }
        private bool CanSearch(object parameter)
        {

            return true;
        }

      

        private ICommand _buyCommand;
        public ICommand BuyCommand => _buyCommand ??= new RelayCommand(Buy,CanBuy);

        private void Buy(object parameter)
        {

            if (ProductsView.LangButton.Content.ToString().ToLower() == "en")
            {
                MessageBox.Show("Already yours and sent to you. Wait for delivery soon!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Куплено! Ожидайте доставку в ближайшее время!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private bool CanBuy(object parameter){
            return true;
        }


        private ICommand _addCommand;
        public ICommand AddCommand => _addCommand ??= new RelayCommand(Add,CanAdd);


        private void Add(object parameter)
        {
            AddView addView = new AddView(this);
            addView.ShowDialog();

        }

        private bool CanAdd(object parameter)
        {
            return true;
        }

        private ICommand _deleteCommand;
        public ICommand DeleteCommand => _deleteCommand ??= new RelayCommand(Delete,CanDelete);
            
        private void Delete(object parameter)
        {

        }

        private bool CanDelete(object parameter)
        {
            return true;
        }

        

        public void SerializeProducts()
        {

            var jsonPath = "C:\\Users\\Manmade\\Desktop\\4sem\\OOP\\Lab code\\lab4-5\\SoftwareShop\\SoftwareShop\\Data\\products.json";
            if (File.Exists(jsonPath))
            {
                var options = new JsonSerializerOptions { WriteIndented = true }; // Optional: formats JSON nicely

                string jsonString = JsonConvert.SerializeObject(AllProducts, Formatting.Indented);

                File.WriteAllText(jsonPath, jsonString);
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("Nope!");
            }
        }





        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propName = null)
             => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
