using SoftwareShop.Helpers;
using SoftwareShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SoftwareShop.ViewModels
{
    public class AccountViewModel : INotifyPropertyChanged
    {
        private readonly User _user;

        public AccountViewModel(User user)
        {
            _user = user ?? throw new ArgumentNullException(nameof(user));

            // инициализируем поля из модели
            Name = _user.Name;
            Email = _user.Email;
            Password = _user.Password;

            Languages = new ObservableCollection<string> { "Русский", "English" };
            Themes = new ObservableCollection<string> { "Light", "Dark" };

            SelectedLanguage = Languages[0];
            SelectedTheme = Themes[0];

            SaveCommand = new RelayCommand(_ => SaveChanges());
            ChangeLanguageCommand = new RelayCommand(_ => ApplyLanguage());
            ChangeThemeCommand = new RelayCommand(_ => ApplyTheme());
        }

        // Поля для редактирования
        private string _name;
        public string Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(); }
        }

        private string _email;
        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(); }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }

        // Lang & Theme
        public ObservableCollection<string> Languages { get; }
        public ObservableCollection<string> Themes { get; }

        private string _selectedLanguage;
        public string SelectedLanguage
        {
            get => _selectedLanguage;
            set { _selectedLanguage = value; OnPropertyChanged(); }
        }

        private string _selectedTheme;
        public string SelectedTheme
        {
            get => _selectedTheme;
            set { _selectedTheme = value; OnPropertyChanged(); }
        }

        // Команды
        public ICommand SaveCommand { get; }
        public ICommand ChangeLanguageCommand { get; }
        public ICommand ChangeThemeCommand { get; }

        private void SaveChanges()
        {
            // Обновляем модель (в реале — в БД или сервисе)
            _user.Name = Name;
            _user.Email = Email;
            _user.Password = Password;

            Data.Repository.userRepository.UpdateUser(_user);
            MessageBox.Show("Данные сохранены", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ApplyLanguage()
        {
            ((App)Application.Current).ChangeLanguage(SelectedLanguage == "English"? "en":"ru");
        }

        private void ApplyTheme()
        {
            // Заглушка: в реале здесь меняем словарь темы
            MessageBox.Show($"Тема переключена на «{SelectedTheme}»");
            var appDicts = Application.Current.Resources.MergedDictionaries;

            // Ищем и удаляем существующий словарь темы (LightTheme или DarkTheme)
            var existingTheme = appDicts
                .FirstOrDefault(d =>
                    d.Source.OriginalString.EndsWith("Light.xaml", StringComparison.OrdinalIgnoreCase) ||
                    d.Source.OriginalString.EndsWith("Dark.xaml", StringComparison.OrdinalIgnoreCase));

            if (existingTheme != null)
                appDicts.Remove(existingTheme);

            // Выбираем новую тему на смену
            var themeFile =  $"Resources/{SelectedTheme}.xaml";

            appDicts.Add(new ResourceDictionary
            {
                Source = new Uri(themeFile, UriKind.Relative)
            });
        }


        


        // INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string p = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(p));
    }


}
