using System.IO;
using System.Text.Json;

namespace lab2
{
    public static class Formatter
    {
        public static void ToJsonFile<T>(T instance)
        {

            var serializedString = JsonSerializer.Serialize(instance);
            
            File.WriteAllText("/Users/Manmade/Desktop/History.json", serializedString);
        }
    }
}
