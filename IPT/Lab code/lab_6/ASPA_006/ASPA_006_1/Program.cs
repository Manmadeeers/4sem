using ASPA_006_1;
using DAL_Celebrity_MSSQL;
using Microsoft.Extensions.Options;
internal class Program
{
    private static void Main(string[] args)
    {
        string CS = "Server=(LocalDb)\\MSSQLLocalDB; Database = Lab6_Db; TrustServerCertificate=True; Trusted_Connection=true";
        Init init = new Init(CS);
        Init.Execute(create: true, delete: true);
        IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("Celebrities.config.json").Build();
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<IRepository, Repository>((IServiceProvider p) =>
        {
            CelebritiesConfig config = p.GetRequiredService<IOptions<CelebritiesConfig>>().Value;
            return new Repository(config.ConnectionString);
        });

        var app = builder.Build();

        app.UseExceptionHandler("/Errors");
        app.MapGet("/", () => "Hello World!");

        var celebrities = app.MapGroup("/api/Celebrities");

        //get all celebrities
        celebrities.MapGet("/", (IRepository repo) => repo.GetAllCelebrities);

        //get celebrity by it's id

        celebrities.MapGet("/{id:int:min(1)}", (IRepository repo, int id) => repo.GetCelebrityById(id));

        //get celebrity by event's id

        celebrities.MapGet("/LifeEvents/{id:int:min(1)}", (IRepository repo, int id) => repo.GetCelebrityByLifeEventId(id));

        //delete celebrity by it's id

        celebrities.MapDelete("/{id:int:min(1)}", (IRepository repo, int id) => repo.DeleteCelebrity(id));

        //add a new celebrity

        celebrities.MapPost("/", (IRepository repo, Celebrity celeb) => repo.AddCelebrity(celeb));

        //change celebrity by it's id

        celebrities.MapPut("/{id:int:min(1)}", (IRepository repo, int id, Celebrity newCeleb) => repo.UpdateCelebrity(id, newCeleb));

        //get photo by filename

        celebrities.MapGet("/photo/{fname}", async (IRepository repo, string fname) =>
        {
            var photoFoler = configuration.GetSection("Celebrities").GetSection("PhotosFolder").Value;
            var photoPath = Path.Combine(photoFoler, fname);
            if (!File.Exists(photoPath))
            {
                throw new FileNotFoundException($"Photo file was not found by requirement({fname})");
            }
            else
            {
                try
                {
                    var bytes = await File.ReadAllBytesAsync(photoPath);
                    string contentType = GetContentTypeByExtension(Path.GetExtension(photoPath));
                    return Results.File(bytes, contentType);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return Results.Problem(ex.Message);
                }
            }

        });


        var lifeEvents = app.MapGroup("/api/lifeEvents");

        //get all lifeevents

        lifeEvents.MapGet("/", (IRepository repo) => repo.GetAllLifeEvents());

        //get lifeevent by it's id

        lifeEvents.MapGet("/{id:int:min(1)}", (IRepository repo, int id) => repo.GetLifeEventById(id));

        //get all lifeevents by elebritie's id

        lifeEvents.MapGet("/Celebrities/{id:int:min(1)}", (IRepository repo, int id) => repo.GetLifeEventsByCelebrityId(id));

        //delete lifeevent by it's id


        lifeEvents.MapDelete("/{id:int:min(1)}", (IRepository repo, int id) => repo.DeleteLifeEvent(id));

        //add new lifeevent

        lifeEvents.MapPost("/",(IRepository repo,LifeEvent LifeEvent)=>repo.AddLifeEvent(LifeEvent));

        //change lifeevent by it's id

        lifeEvents.MapPut("/{id:int:min(1)}", (IRepository repo, int id, LifeEvent newEvent) => repo.UpdateLifeEvent(id, newEvent));

        app.Run();
    }


    static string GetContentTypeByExtension(string extension)
    {
        return extension.ToLower() switch
        {
            ".jpg" => "image/jpeg",
            ".jpeg" => "image/jpeg",
            ".png" => "image/png",
            ".gif" => "image/gif",
            ".bmp" => "image/bmp",
            _ => "application/octet-stream",
        };
    }
}