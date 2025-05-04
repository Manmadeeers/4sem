using SoftwareShop.Helpers;
using SoftwareShop.Models;
using SoftwareShop.Views;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Windows;
using System.Windows.Input;

namespace SoftwareShop.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;

        private LoginView _loginView;
        public LoginViewModel(LoginView loginView)
        {
            _loginView = loginView;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged();
                    LoginCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                    LoginCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private RelayCommand _loginCommand;
        public RelayCommand LoginCommand => _loginCommand ??= new RelayCommand(Login, CanLogin);


        private ICommand _goToSignUpCommand;
        public ICommand GoToSignUpCommand => _goToSignUpCommand ??= new RelayCommand(GoToSignUpPage, CanGoToSignUp);

        private bool CanLogin(object parameter)
        {
            return !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);
        }

        private void Login(object parameter)
        {
            bool success = true;
            // Реальная логика авторизации должна быть здесь
            if (Username == "admin" && Password == "1234")
            {
                success = true;
                User adminUser = new User(666, Username, $"{Username}@gmail.com", Password, true);
                MessageBox.Show($"Welcome, {Username}!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (Username == "user" && Password == "0987")
            {
                success = true;
                User averageUser = new User(1, Username, $"{Username}@gmail.com", Password, false);
                MessageBox.Show($"Welcome, {Username}!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                success = false;
                MessageBox.Show("Incorrect username or password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Password = string.Empty;
            }


            Username = string.Empty;
            Password = string.Empty;

            if (success)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                _loginView.Close();
            }
           
        }

        private bool CanGoToSignUp(object parameter) => true;
        private void GoToSignUpPage(object sender)
        {
            SignUpView signUpPage = new SignUpView();
            signUpPage.Show();
            _loginView.Close();
        }
        


        protected void OnPropertyChanged([CallerMemberName] string propName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
