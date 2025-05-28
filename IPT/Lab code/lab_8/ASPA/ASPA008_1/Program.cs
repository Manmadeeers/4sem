using DAL_Celebrity_MSSQL;
using ASPA008_1.Helpers;
using ASPA008_1.Filters;
using Microsoft.AspNetCore.Mvc;

internal class Program
{
    private static void Main(string[] args)
    {
      
        var builder = WebApplication.CreateBuilder(args);
        builder.AddCelebrityServices();
        builder.AddCelebritiesConfig();

        IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("Celebrities.config.json").Build();
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
          
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseANCErrorHandler("ANC28");
        app.MapCelebrities(configuration);


        app.UseAuthorization();

        app.MapControllerRoute(
            name:"celebrity",
            pattern:"/0",
            defaults:new {Controller="Celebrities",Action="NewHumanForm"}
            );

        app.MapControllerRoute(
            name: "celebrity",
            pattern: "/{id:int:min(1)}",
            defaults: new { Controller = "Celebrities", Action = "Human" }
            );

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Celebrities}/{action=Index}/{id?}");

        app.Run();
    }
}