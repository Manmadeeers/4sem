var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "My first ASPA!");

app.Run();
