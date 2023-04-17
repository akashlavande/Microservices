using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

var ocelotJson = Path.Combine(Directory.GetCurrentDirectory(), "ocelot.json");
builder.Configuration.AddJsonFile(ocelotJson, false, true);
builder.Services.AddOcelot();

var app = builder.Build();

app.UseRouting();

app.MapControllers();

app.UseOcelot();

app.Run();
