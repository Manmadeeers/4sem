using SoftwareShop.Helpers;
using SoftwareShop.Models;
using SoftwareShop.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace SoftwareShop.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {

        //-----Fields and Properties-----//
        private string _username;
        private string _password;
        private LoginView _loginView;


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

        //-----End of Fields and Properties-----//


        public LoginViewModel(LoginView loginView)
        {
            _loginView = loginView;
        }

        

        //-----Commands-----//
        private RelayCommand _loginCommand;
        public RelayCommand LoginCommand => _loginCommand ??= new RelayCommand(Login, CanLogin);


        private ICommand _goToSignUpCommand;
        public ICommand GoToSignUpCommand => _goToSignUpCommand ??= new RelayCommand(GoToSignUpPage, CanGoToSignUp);
        //-----End of Commands-----//


        //-----Methods-----//
        private bool CanLogin(object parameter)
        {
            return !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);
        }

        private void Login(object parameter)
        {
            bool success = true;
            User loggedUser = new User() ;
            
            if (Data.Repository.userRepository.GetAllUsers().Any((ob) => this.Username == ob.Name))
            {
                User maby = Data.Repository.userRepository.GetAllUsers().Find((ob) => this.Username == ob.Name);
                if (maby.Password.Equals(Password))
                {
                    loggedUser = maby;
                }
                else
                {
                    success = false;
                    MessageBox.Show("Incorrect username or password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    Password = string.Empty;
                    return;
                }
            }
            else
            {
                success = false;
                MessageBox.Show("Incorrect username or password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                Password = string.Empty;
                return;
            }


            Username = string.Empty;
            Password = string.Empty;

            if (success)
            {
                if (loggedUser.IsAdmin)
                {
                    loggedUser.Role = "Admin";
                }
                else
                {
                    loggedUser.Role = "User";
                }
                ProductsView productsView = new ProductsView(loggedUser);
                
                productsView.Show();

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

        //-----End of Methods-----//



        //-----Events-----//
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

        //-----End of Events-----//
    }
}
