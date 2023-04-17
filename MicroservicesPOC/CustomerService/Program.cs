using CustomerService.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(config =>
{
    config.RespectBrowserAcceptHeader = true;
    config.ReturnHttpNotAcceptable = true;
}).AddXmlSerializerFormatters();

// It is not woking with gateway routing. Need to work on it!
//builder.Services.AddApiVersioning(config =>
//{
//    config.DefaultApiVersion = new ApiVersion(1, 0);
//    config.AssumeDefaultVersionWhenUnspecified = true;
//    config.ReportApiVersions = true;
//    config.ApiVersionReader = new UrlSegmentApiVersionReader();
//});

builder.Services.AddScoped<ICustomerService, CustomerServic>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
