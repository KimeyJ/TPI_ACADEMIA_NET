using Domain;
using Domain.Services;
using Domain.Model;

using Domain.Services;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<AcademiaContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //Falta configurar de manera correcta        
    app.UseHttpLogging();
}

app.UseHttpsRedirection();

//Actualmente estamos usando los objetos del Domain Model, deberiamos usar ViewModels o DTOs         


app.MapGet("/especialidades/{id}", (int id) =>
{
    EspecialidadService especialidadService = new EspecialidadService();

    return especialidadService.Get(id);
})
.WithName("GetEspecialidades")
.WithOpenApi();

app.MapGet("/especialidades", () =>
{
    EspecialidadService especialidadService = new EspecialidadService();

    return especialidadService.GetAll();
})
.WithName("GetAllEspecialidades")
.WithOpenApi();

app.MapPost("/especialidades", (Especialidad especialidad) =>
{
    EspecialidadService especialidadService = new EspecialidadService();

    especialidadService.Add(especialidad);
})
.WithName("AddEspecialidad")
.WithOpenApi();

app.MapPut("/especialidades", (Especialidad especialidad) =>
{
    EspecialidadService especialidadService = new EspecialidadService();

    especialidadService.Update(especialidad);
})
.WithName("UpdateEspecialidad")
.WithOpenApi();

app.MapDelete("/especialidades/{id}", (int id) =>
{
    EspecialidadService especialidadService = new EspecialidadService();

    especialidadService.Delete(id);
})
.WithName("DeleteEspecialidad")
.WithOpenApi();

app.Run();
