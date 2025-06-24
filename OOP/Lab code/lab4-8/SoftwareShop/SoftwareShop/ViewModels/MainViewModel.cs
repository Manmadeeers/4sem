using SoftwareShop.Helpers;
using SoftwareShop.Models;
using SoftwareShop.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using SoftwareShop.Data;
using SoftwareShop.Repositories;

namespace SoftwareShop.ViewModels
{
    public class MainViewModel
    {

        //-----Fields and Properties-----//
        public Visibility ItemsDeleteVisibility = Visibility.Collapsed;
        private ProductsView _productsView;
        public AddView AddView;
        private User _loggedUser;
        private ObservableCollection<Product> _products = new ObservableCollection<Product>();
        private ObservableCollection<Product> _allProducts = new ObservableCollection<Product>();
        private Stack<ObservableCollection<Product>> _history = new Stack<ObservableCollection<Product>>();
        private Stack<ObservableCollection<Product>> _redoHistory = new Stack<ObservableCollection<Product>>();
        private string searchText;


        public Stack<ObservableCollection<Product>> History
        {
            get => _history;
            set
            {
                _history = value;
                OnPropertyChanged(nameof(History));
            }
        }
        public Stack<ObservableCollection<Product>> RedoHistory
        {
            get => _redoHistory;
            set
            {
                _redoHistory = value;
                OnPropertyChanged(nameof(RedoHistory));
            }
        }
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


        private ICommand _undoCommand;
        public ICommand UndoCommand => _undoCommand ??= new RelayCommand(Undo, CanUndo);

        private ICommand _redoCommand;
        public ICommand RedoCommand => _redoCommand ??= new RelayCommand(Redo, CanRedo);

        //-----End of Commands-----//




        //-----Methods-----//
        private void Redo(object sender)
        {
            if (_redoHistory.Any())
            {
                // Save current state to undo history before redoing
                History.Push(new ObservableCollection<Product>(AllProducts));

                ObservableCollection<Product> nextState = _redoHistory.Pop();
                AllProducts = nextState; // Restore AllProducts from redo history

                // Refresh Products based on the restored AllProducts
                Products.Clear();
                foreach (var prod in AllProducts)
                {
                    Products.Add(prod);
                }

                // Reapply search filter if necessary
                if (!string.IsNullOrWhiteSpace(SearchText))
                {
                    Search(null);
                }

                OnPropertyChanged(nameof(AllProducts));
                OnPropertyChanged(nameof(Products));
                CommandManager.InvalidateRequerySuggested(); // Re-evaluate CanUndo/CanRedo
            }
        }
        private bool CanRedo(object sender)
        {
            return true;
        }
        private void Undo(object sender)
        {

            if (History.Any())
            {
                // Save current state to redo history before undoing
                _redoHistory.Push(new ObservableCollection<Product>(AllProducts));

                ObservableCollection<Product> previousState = History.Pop();
                AllProducts = previousState; // Restore AllProducts from history

                // Refresh Products based on the restored AllProducts
                Products.Clear();
                foreach (var prod in AllProducts)
                {
                    Products.Add(prod);
                }

               
                if (!string.IsNullOrWhiteSpace(SearchText))
                {
                    Search(null);
                }

                OnPropertyChanged(nameof(AllProducts));
                OnPropertyChanged(nameof(Products));
                CommandManager.InvalidateRequerySuggested(); 
            }

        }
        private bool CanUndo(object sender)
        {
            return true;
        }
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
            History.Push(new ObservableCollection<Product>(AllProducts));
            _redoHistory.Clear(); 

            AddView addView = new AddView(this);
            bool? result = addView.ShowDialog(); 

           
            if (result == true) 
            {
                LoadProducts(); 

                
                if (!string.IsNullOrWhiteSpace(SearchText))
                {
                    Search(null);
                }
            }
            CommandManager.InvalidateRequerySuggested();
        }

        private bool CanAdd(object parameter)
        {
            return true;
        }

     
            
        private void Delete(object parameter)
        {
            if (parameter is Product product)
            {
                
                History.Push(new ObservableCollection<Product>(AllProducts));
                _redoHistory.Clear(); 
                _products.Remove(product); 
                AllProducts.Remove(product); 

                Data.Repository.productRepository.DeleteProduct(product.Id); 
                
                CommandManager.InvalidateRequerySuggested();
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
