using Microsoft.AspNetCore.HttpLogging;
using Microsoft.Extensions.Logging;
internal class Program//класс, в котором находитс€ статический метод Main
{
    private static void Main(string[] args)//сам метод - точка входа в программу
    {
        var builder = WebApplication.CreateBuilder(args);//создание новго экземпл€ра WebApplication который и создаЄт web приложение и необходимые 
        //файлы: конфигурационные и тд, логирование настраивает ещЄ

        builder.Services.AddHttpLogging(o =>//вывод в журнал
        {
            o.LoggingFields = HttpLoggingFields.RequestMethod | //метод запроса
                                HttpLoggingFields.RequestPath | //путь запроса
                                HttpLoggingFields.ResponseStatusCode;//код ответа


        });

        builder.Logging.AddFilter("Microsoft.AspNetCore.HttpLogging", LogLevel.Information);//добавл€ем фильтр
        var app = builder.Build();//создаЄм экзмепл€р WebApplication на основе настроек из buildera
       
        app.UseHttpLogging();//вывод в журнал

        app.MapGet("/", () => "My first ASPA!");//определ€ем маршрут дл€ GET запросов.
        // MaoGet щадаЄт endpoint, по которому будут обрадатыватьс€ GET запросы
        //

        app.Run();//запускаем и начинаем слушать на наличие HTTP запросов
    }
}