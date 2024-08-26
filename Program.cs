using Microsoft.EntityFrameworkCore;
using PotakusAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar el DbContext con la cadena de conexion
builder.Services.AddDbContext<PotakuAppContext>(options => 
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("PotakuAppDb"),
        sqlServerOptions => sqlServerOptions.EnableRetryOnFailure()
    ));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
