using System.Windows;
using System.Windows.Controls;
using SoftwareShop.Models;
using SoftwareShop.ViewModels;


namespace SoftwareShop.Views
{
    /// <summary>
    /// Логика взаимодействия для ProductsView.xaml
    /// </summary>
    public partial class ProductsView : Window
    {
        public ProductsView(User loggedUser)
        {
            InitializeComponent();
            MainViewModel context = new MainViewModel();
            context.ProductsView = this;
           
            context.LoggedUser = loggedUser;
            DataContext = context;

            if (loggedUser.IsAdmin)
            {
                this.AddNewButton.Visibility = Visibility.Visible;
            }
        }

        private void ChangeLang(object sender, EventArgs e)
        {
            if (sender is Button btn)
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
