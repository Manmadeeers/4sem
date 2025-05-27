using ASPA007_1;
using DAL_Celebrity_MSSQL;
using Exceptions;
namespace ASPA_007_1
{

    internal class Program
    {
        private static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            builder.AddCelebritiesConfig();
            builder.AddCelebrityServices();

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("Celebrities.config.json").Build();

            builder.Services.AddRazorPages(
                o =>
                {
                    o.Conventions.AddPageRoute("/Celebrities", "/");
                    o.Conventions.AddPageRoute("/NewCelebrity", "/0");
                    o.Conventions.AddPageRoute("/Celebrity", "/Celebrities/{id:int:min(1)}");
                    o.Conventions.AddPageRoute("/Celebrity", "/{id:int:min(1)}");
                });

            var app = builder.Build();



            
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");

                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();
            app.MapCelebrities(configuration);
            app.Run();
        }
    }


  

}