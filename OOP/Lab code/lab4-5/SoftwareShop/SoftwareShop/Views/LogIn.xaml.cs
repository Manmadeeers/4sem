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

        private void LangChngeClick(object sender, RoutedEventArgs e)
        {
            if(sender is Button btn)
            {
                if (btn.Content.ToString().ToLower() == "en")
                {
                    ((App)Application.Current).ChangeLanguage("ru");
                    btn.Content = "Ru";
                }
                else if (btn.Content.ToString().ToLower() == "ru")
                {
                    ((App)Application.Current).ChangeLanguage("en");
                    btn.Content = "En";
                }
            }
        }
    }
}
