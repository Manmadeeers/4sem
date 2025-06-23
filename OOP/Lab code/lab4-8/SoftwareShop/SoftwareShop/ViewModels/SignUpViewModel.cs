using SoftwareShop.Helpers;
using SoftwareShop.Models;
using SoftwareShop.Repositories;
using SoftwareShop.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace SoftwareShop.ViewModels
{
    public class SignUpViewModel : INotifyPropertyChanged
    {
        //-----Fields and Properties-----//
        private string _username;
        private string _email;
        private string _password;
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


        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;

                    ((RelayCommand)SignUpCommand).RaiseCanExecuteChanged();
                }
            }
        }

        public SignUpView SignUpView { get; private set; }
        //-----End of fields and properties-----//



        public SignUpViewModel(SignUpView view)
        {
            SignUpView = view;
        }

      
        //-----Commands-----//
        private ICommand _signUpCommand;
        public ICommand SignUpCommand => _signUpCommand ??= new RelayCommand(SignUp, CanSignUp);

        private ICommand _goToLoginCommand;
        public ICommand GoToLoginCommand => _goToLoginCommand ??= new RelayCommand(GoToLogInPage,CanTransferToPage);

        //-----End of Commands-----//





        //-----Methods-----//

        private bool CanSignUp(object parameter)
        {
            return !string.IsNullOrWhiteSpace(Username)
                && !string.IsNullOrWhiteSpace(Email)
                && !string.IsNullOrWhiteSpace(Password);
        }


        private void SignUp(object parameter)
        {
            
            if (!IsValidEmail(Email))
            {
                MessageBox.Show("Incorrect email!", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
          

           

            MessageBox.Show("Registration successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            Random random = new Random();

            User freshlySignedUser = new User(random.Next(1, 101), Username, Email, Password, false){ Role = "User"};

            Data.Repository.userRepository.AddUser(freshlySignedUser);
            
            Username = string.Empty;
            Email = string.Empty;
            Password = string.Empty;

       
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
        //-----End of methods-----//


        //------Events-----//
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            if (propertyName == nameof(Username) || propertyName == nameof(Email) || propertyName == nameof(Password))
            {
                ((RelayCommand)SignUpCommand).RaiseCanExecuteChanged();
            }
        }
      
        //-----End of Events-----//
    }
}
