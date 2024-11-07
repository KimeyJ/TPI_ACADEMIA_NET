using Domain;
using Domain.Services;
using Domain.Model;
using Domain.Services;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddDbContext<AcademiaContext>(
    //options => options.UseSqlServer(@"Server=.\SQLEXPRESS; Database=Academia; Integrated Security=True; TrustServerCertificate=True")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication("Basic").AddScheme<AuthenticationSchemeOptions, AuthenticationHandler>("Basic", null);
builder.Services.AddAuthorization(options =>
{
    options.DefaultPolicy = new AuthorizationPolicyBuilder("Basic").RequireAuthenticatedUser().Build();
});
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

app.MapGet("/personas/{id}", (int id) =>
{
    PersonaService personaService = new PersonaService();

    return personaService.Get(id);
})
.WithName("Getpersonas")
.WithOpenApi();

app.MapGet("/personas", () =>
{
    PersonaService personaService = new PersonaService();

    return personaService.GetAll();
})
.WithName("GetAllPersonas")
.WithOpenApi();

app.MapPost("/personas", (Persona Persona) =>
{
    PersonaService personaService = new PersonaService();

    return personaService.Add(Persona);
})
.WithName("AddPersona")
.WithOpenApi();

app.MapPut("/personas", (Persona Persona) =>
{
    PersonaService personaService = new PersonaService();

    personaService.Update(Persona);
})
.WithName("UpdatePersona")
.WithOpenApi();

app.MapDelete("/personas/{id}", (int id) =>
{
    PersonaService personaService = new PersonaService();

    personaService.Delete(id);
})
.WithName("DeletePersona")
.WithOpenApi();

app.MapGet("/usuarios/{id}", (int id) =>
{
    UsuarioService usuarioService = new UsuarioService();

    return usuarioService.Get(id);
})
.WithName("Getusuarios")
.WithOpenApi();

app.MapGet("/usuarios", () =>
{
    UsuarioService usuarioService = new UsuarioService();

    return usuarioService.GetAll();
})
.WithName("GetAllUsuarios")
.WithOpenApi();

app.MapPost("/usuarios", (Usuario Usuario) =>
{
    UsuarioService usuarioService = new UsuarioService();

    usuarioService.Add(Usuario);
})
.WithName("AddUsuario")
.WithOpenApi();

app.MapPut("/usuarios", (Usuario Usuario) =>
{
    UsuarioService usuarioService = new UsuarioService();

    usuarioService.Update(Usuario);
})
.WithName("UpdateUsuario")
.WithOpenApi();

app.MapDelete("/usuarios/{id}", (int id) =>
{
    UsuarioService usuarioService = new UsuarioService();

    usuarioService.Delete(id);
})
.WithName("DeleteUsuario")
.WithOpenApi();

app.MapGet("/usuarios/count", () =>
{
    UsuarioService usuarioService = new UsuarioService();

    return usuarioService.CountUsuario();
})
.WithName("CountUsuarios")
.WithOpenApi();

app.MapGet("/usuarios/login/{us}/{ps}", (string us, string ps) =>
{
    UsuarioService usuarioService = new UsuarioService();

    return usuarioService.Authenticate(us, ps);
})
.WithName("AuthenticateUsuarios")
.WithOpenApi();

app.Run();
