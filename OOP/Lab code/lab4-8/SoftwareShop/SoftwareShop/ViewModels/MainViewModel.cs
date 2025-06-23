using SoftwareShop.Helpers;
using SoftwareShop.Models;
using SoftwareShop.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace SoftwareShop.ViewModels
{
    public class MainViewModel
    {

        //-----Fields and Properties-----//
        public Visibility ItemsDeleteVisibility = Visibility.Collapsed;
        private ProductsView _productsView;
        public AddView AddView;
        private User _loggedUser;
        private ObservableCollection<Product> _products;
        private ObservableCollection<Product> _allProducts;
        private string searchText;
        public ProductsView ProductsView
        {
            get { return  _productsView; }
            set { _productsView = value; }
        }
        public User LoggedUser
        {
            get { return _loggedUser; }
            set { _loggedUser = value; }
        }
        public ObservableCollection<Product> Products
        {
            get => _products;
            set { _products = value; OnPropertyChanged(nameof(Products)); }
        }

        public ObservableCollection<Product> AllProducts
        {
            get => _allProducts;
            set { _allProducts = value; OnPropertyChanged(nameof(AllProducts)); }
        }
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

        //-----End of Fields and Properties-----//


        public MainViewModel()
        {
            Debug.WriteLine("MainViewModel created");
            LoadProducts();
            Debug.WriteLine($"Products loaded: {Products?.Count}");
            
        }

        //-----Commands-----//
        private ICommand _unloginCommand;
        public ICommand UnloginCommand => _unloginCommand ??= new RelayCommand(Unlogin,CanUnlogin);

        private ICommand _searchCommand;
        public ICommand SearchCommand => _searchCommand ??= new RelayCommand(Search, CanSearch);


        private ICommand _buyCommand;
        public ICommand BuyCommand => _buyCommand ??= new RelayCommand(Buy, CanBuy);

        private ICommand _addCommand;
        public ICommand AddCommand => _addCommand ??= new RelayCommand(Add, CanAdd);

        private ICommand _deleteCommand;
        public ICommand DeleteCommand => _deleteCommand ??= new RelayCommand(Delete, CanDelete);

        private ICommand _viewAcc;
        public ICommand ViewAcc => _viewAcc ??= new RelayCommand(ViAc, (object parameter) => true);

        //-----End of Commands-----//




        //-----Methods-----//
        private void Unlogin(object sender)
        {
            LoginView loginView = new LoginView();
            loginView.Show();
            _productsView.Close();
        }

        private void ViAc(object sender)
        {
            AccountView accountView = new AccountView(LoggedUser);
            accountView.Show();

        }
        private bool CanUnlogin(object sender)
        {
            return true;
        }
        private void LoadProducts()
        {
          //TODO - real load products logic here
           _products = new ObservableCollection<Product>(Data.Repository.productRepository.GetAllProducts());
           
        }


       
        private void Search(object parameter)
        {


            if (string.IsNullOrWhiteSpace(searchText))
            {
                Products.Clear();
                foreach(var product in AllProducts)
                {
                    Products.Add(product);
                }
                Debug.WriteLine("Empty search field");
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


        private void Buy(object parameter)
        {
        }

        private bool CanBuy(object parameter){
            return true;
        }


     

        private void Add(object parameter)
        {
            AddView addView = new AddView(this);
            addView.ShowDialog();

        }

        private bool CanAdd(object parameter)
        {
            return true;
        }

     
            
        private void Delete(object parameter)
        {
            if (parameter is Product product)
            {
                _products.Remove(product);
                Data.Repository.productRepository.DeleteProduct(product.Id);
            }
        }

        private bool CanDelete(object parameter)
        {
            return _loggedUser.IsAdmin;
        }


        //-----End of Methods-----//


        //-----Events-----//

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propName = null)
             => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

        //-----End of Events-----//
    }
}
