using System.Windows;
using System.Windows.Controls;
using SoftwareShop.ViewModels;

namespace SoftwareShop.Views
{
    public partial class LoginView :Window
    {
        public LoginView()
        {
            InitializeComponent();
            DataContext = new LoginViewModel(this);
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is ViewModels.LoginViewModel vm)
            {
                vm.Password = ((PasswordBox)sender).Password;
            }
        }
    }
}
