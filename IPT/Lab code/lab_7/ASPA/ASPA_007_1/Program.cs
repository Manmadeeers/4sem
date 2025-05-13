using DAL_Celebrity_MSSQL;
using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;
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
            // Add services to the container.
            builder.Services.AddRazorPages(
                o =>
                {
                    o.Conventions.AddPageRoute("/Celebrities", "/");
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

            app.Run();
        }
    }


    static class BuilderHelper
    {
        public static  IServiceCollection AddCelebritiesConfig(this WebApplicationBuilder builder, string JsonFileName = "Celebrities.config.json")
        {
            builder.Configuration.AddJsonFile(JsonFileName);
            return builder.Services.Configure<CelebritiesConfig>(builder.Configuration.GetSection("Celebrities"));    
            
        }
        public static IServiceCollection AddCelebrityServices(this WebApplicationBuilder builder, string JsonFileName = "Celebrities.config.json")
        {
            builder.Services.AddScoped<IRepository, Repository>((p) =>
            {
                return new Repository(builder.Configuration.GetSection("Celebrities").GetValue<string>("ConnectionString"));
            });
            return builder.Services;
        }
    }

}


