

//using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Text.Json;

namespace SoftwareShop.Helpers
{
    public static class Serializer
    {
        private static string jsonPath = "C:\\Users\\Manmade\\Desktop\\4sem\\OOP\\Lab code\\lab4-5\\SoftwareShop\\SoftwareShop\\Data\\products.json";
        public static void SaveCollectionToFile<T>( ObservableCollection<T> collection)
        {
            // Сериализуем всю коллекцию в JSON
            //string jsonString = JsonSerializer.Serialize(collection, new JsonSerializerOptions
            //{
            //    WriteIndented = true
            //});

            //// Перезаписываем файл новым содержимым
            //File.WriteAllText(jsonPath, jsonString);
        }
    }
}

