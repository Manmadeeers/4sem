using SoftwareShop.Models;
using SoftwareShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SoftwareShop.Views
{
    /// <summary>
    /// Логика взаимодействия для AccountView.xaml
    /// </summary>
    public partial class AccountView : Window
    {
        public AccountView(User user)
        {
            InitializeComponent();
            // Перепривязываем VM, чтобы передать user
            DataContext = new AccountViewModel(user);
        }

        private void PasswordBox_PasswordChanged(object sender, System.Windows.RoutedEventArgs e)
        {
            var vm = (AccountViewModel)DataContext;
            vm.Password = ((PasswordBox)sender).Password;
        }
    }
}
