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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab4_5.Views
{
    /// <summary>
    /// Логика взаимодействия для SignUpView.xaml
    /// </summary>
    public partial class SignUpView : UserControl
    {
        public SignUpView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Add signup logic here
            string username = ((TextBox)this.FindName("UsernameTextBox")).Text;
            string email = ((TextBox)this.FindName("EmailTextBox")).Text;
            string password = ((PasswordBox)this.FindName("PasswordBox")).Password;

            // Implement validation and registration logic
            MessageBox.Show($"Registration attempted:\nUsername: {username}\nEmail: {email}");
        }
    }
}
