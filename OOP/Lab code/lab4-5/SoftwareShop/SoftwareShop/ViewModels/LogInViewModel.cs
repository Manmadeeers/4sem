using SoftwareShop.Helpers;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace SoftwareShop.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;

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

        private bool CanLogin(object parameter)
        {
            return !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);
        }

        private void Login(object parameter)
        {
            // Реальная логика авторизации должна быть здесь
            if (Username == "admin" && Password == "1234")
            {
                MessageBox.Show($"Добро пожаловать, {Username}!", "Успешный вход", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Password = string.Empty;
            }
        }


        protected void OnPropertyChanged([CallerMemberName] string propName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
