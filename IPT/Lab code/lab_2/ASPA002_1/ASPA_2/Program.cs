
internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();


        app.UseWelcomePage("/aspnetcore");

        app.MapGet("/aspnetcore", () => "Hi there!");

        app.UseDefaultFiles(new DefaultFilesOptions
        {
            DefaultFileNames = new List<string> { "neuman.html" }
        });
        app.UseStaticFiles();
        app.Map("/static", stat_app =>
        {
            stat_app.UseStaticFiles();
        });


        app.Run();
    }
}