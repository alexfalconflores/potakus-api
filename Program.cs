using Microsoft.AspNetCore.Routing.Patterns;
using Microsoft.EntityFrameworkCore;
using PotakusAPI.Data;
using PotakusAPI.Endpoints;
using PotakusAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurar el DbContext con la cadena de conexion
builder.Services.AddDbContext<PotakuAppContext>(options => 
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("PotakuAppDb"),
        sqlServerOptions => sqlServerOptions.EnableRetryOnFailure()
    ));

// Registrar los repositorios
builder.Services.AddScoped<IItemRepository, ItemRepository>();
builder.Services.AddScoped<IThemeRepository, ThemeRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Registrar los endpoints
app.MapThemeEndpoints();

app.Run();
