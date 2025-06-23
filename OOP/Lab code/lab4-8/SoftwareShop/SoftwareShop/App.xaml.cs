using Microsoft.Data.SqlClient;
using System.Windows;

namespace SoftwareShop
{

    public partial class App : Application
    {


        public void ChangeLanguage(string lang)
        {
            var dictUri = new Uri($"Resources/Local.{lang}.xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(dictUri) as ResourceDictionary;

            var oldDict = Application.Current.Resources.MergedDictionaries.FirstOrDefault(d => d.Source != null && d.Source.OriginalString.StartsWith("Resources/Local."));
            if (oldDict != null)
            {
                Application.Current.Resources.MergedDictionaries.Remove(oldDict);
            }

            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

    }

}
