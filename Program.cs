using Microsoft.EntityFrameworkCore;
using PotakusAPI.Data;
using PotakusAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configurar el DbContext con la cadena de conexion
builder.Services.AddDbContext<PotakuAppContext>(options => 
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("PotakuAppDb"),
        sqlServerOptions => sqlServerOptions.EnableRetryOnFailure()
    ));

// Registrar los repositorios
builder.Services.AddScoped<IItemRepository, ItemRepository>();

var app = builder.Build();


app.Run();
