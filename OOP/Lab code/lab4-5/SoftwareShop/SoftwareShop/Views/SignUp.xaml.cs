using System.Windows;
using System.Windows.Controls;
using SoftwareShop.ViewModels;

namespace SoftwareShop.Views
{
    public partial class SignUpView : Window
    {
        public SignUpView()
        {
            InitializeComponent();
            DataContext = new SignUpViewModel(this);
        }


        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is SignUpViewModel vm)
            {
                vm.Password = ((PasswordBox)sender).Password;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
