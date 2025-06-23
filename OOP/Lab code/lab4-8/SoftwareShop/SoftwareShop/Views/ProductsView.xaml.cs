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
        public User logged = new User();
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

                context.ItemsDeleteVisibility = Visibility.Visible;
                
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
        private bool _isDark = false;
        private void OnToggleTheme(object sender, RoutedEventArgs e)
        {
            var appDicts = Application.Current.Resources.MergedDictionaries;

            // Ищем и удаляем существующий словарь темы (LightTheme или DarkTheme)
            var existingTheme = appDicts
                .FirstOrDefault(d =>
                    d.Source.OriginalString.EndsWith("Light.xaml", StringComparison.OrdinalIgnoreCase) ||
                    d.Source.OriginalString.EndsWith("Dark.xaml", StringComparison.OrdinalIgnoreCase));

            if (existingTheme != null)
                appDicts.Remove(existingTheme);

            // Выбираем новую тему на смену
            var themeFile = _isDark
                ? "Resources/Light.xaml"
                : "Resources/Dark.xaml";

            appDicts.Add(new ResourceDictionary
            {
                Source = new Uri(themeFile, UriKind.Relative)
            });

            _isDark = !_isDark;
        }

        public bool IsFeatureOn { get; set; } = false;


        private void Second_Tunnel(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tunneling event");
        }

        private void Second_Bubble(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bubbling event");
        }

        private void First_Direct(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Direct event fired!");
        }

    }
}
