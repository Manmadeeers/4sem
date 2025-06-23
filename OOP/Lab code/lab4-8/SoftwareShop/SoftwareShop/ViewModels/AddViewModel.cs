using SoftwareShop.Helpers;
using SoftwareShop.Models;
using SoftwareShop.Views;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;


namespace SoftwareShop.ViewModels
{
    public class AddViewModel
    {

        //-----Fields and Properties-----//
        private string _name;
        private string _description;
        private decimal _price;
        private AddView _addView;
        private string _imagePath;
        private MainViewModel _mainViewModel;


        public MainViewModel MainModel
        {
            get { return _mainViewModel; }
            set { _mainViewModel = value; }
        }

        public AddView AddView
        {
            get { return _addView; }
            private set { _addView = value; }
        }

        public string Name 
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
          
            }
        }

        public string ImagePath
        {
            get => _imagePath;
            set
            {
                _imagePath = value;
                OnPropertyChanged();
            }
        }
        //-----End of Fields and Properties----//


    
        public AddViewModel(AddView addView)
        {
            _addView = addView;
        }


        //-----Commands-----//
        private ICommand _cancelCommnd;
        public ICommand CancelCommand => _cancelCommnd ??= new RelayCommand(Cancel, CanCancel);

        private ICommand _addNewCommand;
        public ICommand AddNewCommand => _addNewCommand ??= new RelayCommand(AddNew, CanAddNew);
        
        //-----End of Commands-----//


        //-----Methods-----//
        private void Cancel(object parameter)
        {
            this._addView.Close();
        }
        private bool CanCancel(object parameter)
        {
            return true;
        }

        
        public void AddNew(object parameter)
        {
            Product product = new Product();
            product.Name = Name;
            product.Description = Description;
            product.Price = Price;
            product.DetailedDescription = "";

            product.ImagePath = Path.Combine("C:\\Users\\Manmade\\Desktop\\4sem\\OOP\\Lab code\\lab4-5\\SoftwareShop\\SoftwareShop\\Images\\", ImagePath);

            MainModel.AllProducts.Add(product);
            Data.Repository.productRepository.AddProduct(product);
            Serializer.SaveCollectionToFile(MainModel.AllProducts);
            MessageBox.Show("Added");
            AddView.Close();
        }


        
        public bool CanAddNew(object parameter)
        {
            return true;
        }

        //-----End of Methods-----//


        //-----Events-----//
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null)
          => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

        //-----End of Events-----//
    }
}
