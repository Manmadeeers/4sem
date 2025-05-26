using System.Windows;
using SoftwareShop.ViewModels;

namespace SoftwareShop.Views
{
    /// <summary>
    /// Логика взаимодействия для AddView.xaml
    /// </summary>
    public partial class AddView : Window
    {
        public AddView(MainViewModel model)
        {
           
            InitializeComponent();
            AddViewModel addModel = new AddViewModel(this);
            addModel.MainModel = model;
            DataContext = addModel;
            
        }
    }
}
