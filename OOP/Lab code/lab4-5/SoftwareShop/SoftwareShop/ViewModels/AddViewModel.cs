

using SoftwareShop.Helpers;
using SoftwareShop.Models;
using SoftwareShop.Views;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace SoftwareShop.ViewModels
{
    public class AddViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private AddView _addView;
        private MainViewModel _mainViewModel;
        private string _name;
       public string Name 
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }
        private decimal _price;
        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
          
            }
        }
        private string _imagePath;
        public string ImagePath
        {
            get => _imagePath;
            set
            {
                _imagePath = value;
                OnPropertyChanged();
            }
        }


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
        public AddViewModel(AddView addView)
        {
            _addView = addView;
        }
        private ICommand _cancelCommnd;
        public ICommand CancelCommand => _cancelCommnd ??= new RelayCommand(Cancel, CanCancel);

        private void Cancel(object parameter)
        {

        }
        private bool CanCancel(object parameter)
        {
            return true;
        }

        private ICommand _addNewCommand;
        public ICommand AddNewCommand => _addNewCommand ??= new RelayCommand(AddNew, CanAddNew);

        public void AddNew(object parameter)
        {
            Product product = new Product();
            product.Name = Name;
            product.Description = Description;
            product.Price = Price;

            product.ImagePath = Path.Combine("C:\\Users\\Manmade\\Desktop\\4sem\\OOP\\Lab code\\lab4-5\\SoftwareShop\\SoftwareShop\\Images\\", ImagePath);

            MainModel.AllProducts.Add(product);
            Serializer.SaveCollectionToFile(MainModel.AllProducts);
            MessageBox.Show("Added");
            AddView.Close();
        }


        
        public bool CanAddNew(object parameter)
        {
            //if (string.IsNullOrWhiteSpace(_name) || string.IsNullOrWhiteSpace(_description) || _price == null || string.IsNullOrWhiteSpace(_imagePath))
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
            return true;
        }



        protected void OnPropertyChanged([CallerMemberName] string propName = null)
          => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
