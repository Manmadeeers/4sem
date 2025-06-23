using System.Windows;
using System.Windows.Controls;
using SoftwareShop.ViewModels;

namespace SoftwareShop.Views
{
    public partial class SignUpView : Window
    {
        public SignUpView()
        {
            Data.Repository.Init((string)Application.Current.Resources["Conn"]);
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

        private void LangChangeClick(object sender, RoutedEventArgs e)
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
