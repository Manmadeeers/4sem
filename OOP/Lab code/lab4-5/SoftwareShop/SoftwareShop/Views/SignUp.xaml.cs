using System.Windows;
using System.Windows.Controls;
using SoftwareShop.ViewModels;

namespace SoftwareShop.Views
{
    public partial class SignUpView : UserControl
    {
        public SignUpView()
        {
            InitializeComponent();
            DataContext = new SignUpViewModel();
        }


        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is SignUpViewModel vm)
            {
                vm.Password = ((PasswordBox)sender).Password;
            }
        }
    }
}
