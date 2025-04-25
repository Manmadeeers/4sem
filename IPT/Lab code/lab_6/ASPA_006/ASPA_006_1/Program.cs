using ASPA_006_1;
using DAL_Celebrity_MSSQL;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Extensions.Options;
using Exceptions;
internal class Program
{
    private static void Main(string[] args)
    {
        string CS = "Server=DESKTOP-I\\SARVAR; Database=Lab6_Db; Trusted_Connection=true; TrustServerCertificate=Yes";
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

        app.UseDefaultFiles();
        app.UseStaticFiles();

        app.UseExceptionHandler("/Errors");

        var celebrities = app.MapGroup("/api/Celebrities");

        //get all celebrities
        celebrities.MapGet("/", (IRepository repo) => repo.GetAllCelebrities());

        //get celebrity by it's id

        celebrities.MapGet("/{id:int:min(1)}", (IRepository repo, int id) =>
        {
            if (repo.GetCelebrityById(id) != null)
            {
                return repo.GetCelebrityById(id);
            }
            else
            {
                throw new GetByIdException($"Failed to get celebrity by {id} id. Such id does not exist");
            }
        });

        //get celebrity by event's id

        celebrities.MapGet("/LifeEvents/{id:int:min(1)}", (IRepository repo, int id) =>
        {
            Celebrity? celeb = repo.GetCelebrityByLifeEventId(id);
            if(celeb != null)
            {
                return celeb;
            }
            else
            {
                throw new GetByIdException($"Could not get a celebrity by {id} id . Such id does not exist");
            }
        });

        //delete celebrity by it's id

        celebrities.MapDelete("/{id:int:min(1)}", (IRepository repo, int id) =>
        {
            if (repo.DeleteCelebrity(id))
            {
                return $"Celebrity with id {id} was successfully deleted!";
            }
            else
            {
                throw new DeleteByIdException($"Failed to delete celebrity by {id} id. Celebrity with such id does not exist");
            }
        });

        //add a new celebrity

        celebrities.MapPost("/", (IRepository repo, Celebrity celeb) =>
        {
            if (repo.AddCelebrity(celeb))
            {
                celeb.Id = repo.GetCelebrityByName(celeb.FullName);
                return celeb;
            }
            else
            {
                throw new AddException("Failed to add celebrity");
            }
        });

        //change celebrity by it's id

        celebrities.MapPut("/{id:int:min(1)}", (IRepository repo, int id, Celebrity newCeleb) =>
        {
            if(repo.UpdateCelebrity(id, newCeleb))
            {
                newCeleb.Id = repo.GetCelebrityByName(newCeleb.FullName);
                return newCeleb;
            }
            else
            {
                throw new UpdateException($"Failed to update celebrity with id {id}. Something went wrong");
            }
        });

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

        lifeEvents.MapGet("/{id:int:min(1)}", (IRepository repo, int id) =>
        {
            LifeEvent?lifeEvent = repo.GetLifeEventById(id);
            if (lifeEvent != null)
            {
                return lifeEvent;
            }
            else
            {
                throw new GetByIdException($"Failed to get LifeEvent by {id} id");
            }
        });

        //get all lifeevents by elebritie's id

        lifeEvents.MapGet("/Celebrities/{id:int:min(1)}", (IRepository repo, int id) =>
        {
            List<LifeEvent>lifeEventList = repo.GetLifeEventsByCelebrityId(id);
            if (lifeEventList.Count == 0)
            {
                throw new GetByIdException("Failed to get life events by celebritie's id. Something went wrong");
            }
            else
            {
                return lifeEventList;
            }
        });

        //delete lifeevent by it's id


        lifeEvents.MapDelete("/{id:int:min(1)}", (IRepository repo, int id) =>
        {
            if (repo.DeleteLifeEvent(id))
            {
                return $"Life Event with id {id} was deleted";
            }
            else
            {
                throw new DeleteByIdException($"Failed to delete life event by id {id} such id does not exist");
            }
        });

        //add new lifeevent

        lifeEvents.MapPost("/",(IRepository repo,LifeEvent LifeEvent) =>
        {
            if (repo.AddLifeEvent(LifeEvent))
            {
                return LifeEvent;
            }
            else
            {
                throw new AddException("Failed to add life event. Something went wrong");
            }
        });

        //change lifeevent by it's id

        lifeEvents.MapPut("/{id:int:min(1)}", (IRepository repo, int id, LifeEvent newEvent) =>
        {
            if(repo.UpdateLifeEvent(id, newEvent))
            {
                return newEvent;
            }
            else
            {
                throw new UpdateException($"Failed to update celebrity with id {id}. Something went wrong");
            }
        });


        app.Map("/Errors", (HttpContext ctx) =>
        {
            Exception? ex = ctx.Features.Get<IExceptionHandlerFeature>()?.Error;
            IResult rc = Results.Problem(detail: ex.Message, instance: app.Environment.EnvironmentName, title: "ASPA006", statusCode: 500);
            if (ex != null)
            {
                if(ex is AddException )
                {
                    rc = Results.NotFound(ex.Message);
                }
                if(ex is DeleteByIdException)
                {
                    rc= Results.NotFound(ex.Message);
                }
                if(ex is UpdateException)
                {
                    rc = Results.NotFound(ex.Message);
                }
                if(ex is GetByIdException)
                {
                    rc = Results.NotFound(ex.Message);
                }
            }
            return rc;
        });

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