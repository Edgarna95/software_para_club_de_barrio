
using GestionAdministrativaBarracas.Dominio;
using GestionAdministrativaBarracas.Dominio.Repositorios;
using GestionAdministrativaBarracas.Infrastructure;
using GestionAdministrativaBarracas.Infrastructure.Repositories;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ISocioRepository, SocioRepositoryInMemory>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
