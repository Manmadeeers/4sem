using SoftwareShop.Helpers;
using SoftwareShop.Models;
using SoftwareShop.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace SoftwareShop.ViewModels
{
    public class SignUpViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _email;
        private string _password;
        public event PropertyChangedEventHandler PropertyChanged;
        public SignUpView SignUpView { get; private set; }
        public SignUpViewModel(SignUpView view)
        {
            SignUpView = view;
        }

        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged();
                }
            }
        }

        // Password не содержит OnPropertyChanged, чтобы не раскрывать в UI напрямую
        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    // Вызовем обновление доступности команды после смены пароля
                    ((RelayCommand)SignUpCommand).RaiseCanExecuteChanged();
                }
            }
        }

        private ICommand _signUpCommand;
        public ICommand SignUpCommand => _signUpCommand ??= new RelayCommand(SignUp, CanSignUp);

        private ICommand _goToLoginCommand;
        public ICommand GoToLoginCommand => _goToLoginCommand ??= new RelayCommand(GoToLogInPage,CanTransferToPage);

        private bool CanSignUp(object parameter)
        {
            return !string.IsNullOrWhiteSpace(Username)
                && !string.IsNullOrWhiteSpace(Email)
                && !string.IsNullOrWhiteSpace(Password);
        }


        private void SignUp(object parameter)
        {
            // Логика регистрации
            if (!IsValidEmail(Email))
            {
                MessageBox.Show("Incorrect email!", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
          

            // Здесь можно добавить вызов сервиса регистрации и т.п.

            MessageBox.Show("Registration successfull!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            Random random = new Random();

            User freshlySignedUser = new User(random.Next(1,101),Username,Email,Password,false);


            // Очистка формы
            Username = string.Empty;
            Email = string.Empty;
            Password = string.Empty;

            // Очистка PasswordBox в UI (Можно через событие, если потребуется)
           
            ProductsView productsView = new ProductsView(freshlySignedUser);
            productsView.Show();
            SignUpView.Close();

        }


        private void GoToLogInPage(object sender)
        {
            var loginWindow = new LoginView();
            loginWindow.Show();
            SignUpView.Close();
            
        }

        private bool CanTransferToPage(object parameter)
        {
            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            if (propertyName == nameof(Username) || propertyName == nameof(Email) || propertyName == nameof(Password))
            {
                ((RelayCommand)SignUpCommand).RaiseCanExecuteChanged();
            }
        }

    }
}
