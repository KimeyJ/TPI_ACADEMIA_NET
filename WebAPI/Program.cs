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
//builder.Services.AddAuthentication("Basic").AddScheme<AuthenticationSchemeOptions, AuthenticationHandler>("Basic", null);
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

app.MapGet("/personas/consulta/{tp}", (int tp) =>
{
    PersonaService personaService = new PersonaService();

    return personaService.GetAll(tp);
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

app.MapPost("/usuarios/login/", (Usuario usuario) =>
{
    UsuarioService usuarioService = new UsuarioService();

    return usuarioService.Authenticate(usuario.Username, usuario.Password);
})
.WithName("AuthenticateUsuarios")
.WithOpenApi();

app.MapGet("/usuarios/check/{usr}/{id}", (string usr, int id) =>
{
    UsuarioService usuarioService = new UsuarioService();

    return usuarioService.CheckDuplicate(usr, id);
})
.WithName("CheckUserNames")
.WithOpenApi();

app.MapGet("/planes/{id}", (int id) =>
{
    PlanService planService = new PlanService();

    return planService.Get(id);
})
.WithName("GetPlanes")
.WithOpenApi();

app.MapGet("/planes/all/{p_id}", (int p_id) =>
{
    PlanService planService = new PlanService();

    return planService.GetAll(p_id);
})
.WithName("GetAllPlanes")
.WithOpenApi();

app.MapGet("/planes/last/{esp_id}", (int esp_id) =>
{
    PlanService planService = new PlanService();
    return planService.GetLast(esp_id);
})
.WithName("GetLastPlan")
.WithOpenApi();

app.MapPost("/planes", (Plan plan) =>
{
    PlanService planService = new PlanService();

    planService.Add(plan);
})
.WithName("AddPlan")
.WithOpenApi();

app.MapPut("/planes", (Plan plan) =>
{
    PlanService planService = new PlanService();

    planService.Update(plan);
})
.WithName("UpdatePlan")
.WithOpenApi();

app.MapDelete("/planes/{id}", (int id) =>
{
    PlanService planService = new PlanService();

    planService.Delete(id);
})
.WithName("DeletePlan")
.WithOpenApi();

app.MapGet("/materias/{id}/{id_p}", (int id, int id_p) =>
{
    MateriaService materiaService = new MateriaService();

    return materiaService.Get(id, id_p);
})
.WithName("GetMaterias")
.WithOpenApi();

app.MapGet("/materias/plan/{p_id}", (int p_id) =>
{
    MateriaService materiaService = new MateriaService();

    return materiaService.GetAll(p_id);
})
.WithName("GetAllMaterias")
.WithOpenApi();

app.MapPost("/materias", (Materia materia) =>
{
    MateriaService materiaService = new MateriaService();

    materiaService.Add(materia);
})
.WithName("AddMateria")
.WithOpenApi();

app.MapPut("/materias", (Materia materia) =>
{
    MateriaService materiaService = new MateriaService();

    materiaService.Update(materia);
})
.WithName("UpdateMateria")
.WithOpenApi();

app.MapDelete("/materias/{id_m}/{id_p}", (int id_m, int id_p) =>
{
    MateriaService materiaService = new MateriaService();

    materiaService.Delete(id_m, id_p);
})
.WithName("DeleteMateria")
.WithOpenApi();

app.MapGet("/comisiones/{id}", (int id) =>
{
    ComisionService comisionService = new ComisionService();

    return comisionService.Get(id);
})
.WithName("GetComisiones")
.WithOpenApi();

app.MapGet("/comisiones/plan/{id}", (int id) =>
{
    ComisionService comisionService = new ComisionService();

    return comisionService.GetAll(id);
})
.WithName("GetAllComisiones")
.WithOpenApi();

app.MapPost("/comisiones", (Comision comision) =>
{
    ComisionService comisionService = new ComisionService();

    comisionService.Add(comision);
})
.WithName("AddComision")
.WithOpenApi();

app.MapPut("/comisiones", (Comision comision) =>
{
    ComisionService comisionService = new ComisionService();

    comisionService.Update(comision);
})
.WithName("UpdateComision")
.WithOpenApi();

app.MapDelete("/comisiones/{id}", (int id) =>
{
    ComisionService comisionService = new ComisionService();

    comisionService.Delete(id);
})
.WithName("DeleteComision")
.WithOpenApi();

app.MapGet("/cursos/all/{id_m}/{id_c}", (int id_m, int id_c) =>
{
    CursoService cursoService = new CursoService();

    return cursoService.GetAll(id_m, id_c);
})
.WithName("GetAllCursos")
.WithOpenApi();

app.MapGet("/cursos/plan/{id_pl}", (int id_pl) =>
{
    CursoService cursoService = new CursoService();

    return cursoService.GetAllByPlan(id_pl);
})
.WithName("GetAllCursosByPlan")
.WithOpenApi();

app.MapGet("/cursos/{id}", (int id) =>
{
    CursoService cursoService = new CursoService();

    return cursoService.Get(id);
})
.WithName("GetCursos")
.WithOpenApi();

app.MapPost("/cursos", (Curso curso) =>
{
    CursoService cursoService = new CursoService();

    cursoService.Add(curso);
})
.WithName("AddCurso")
.WithOpenApi();

app.MapPut("/cursos", (Curso curso) =>
{
    CursoService cursoService = new CursoService();

    cursoService.Update(curso);
})
.WithName("UpdateCurso")
.WithOpenApi();

app.MapDelete("/cursos/{id}", (int id) =>
{
    CursoService cursoService = new CursoService();

    cursoService.Delete(id);
})
.WithName("DeleteCurso")
.WithOpenApi();

app.Run();
