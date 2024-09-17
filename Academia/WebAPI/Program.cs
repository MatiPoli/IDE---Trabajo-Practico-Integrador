using Domain.Services;
using Domain.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

// Personas
app.MapGet("/personas/{id}", (int id) =>
{
    PersonaService service = new PersonaService();

    return service.Get(id);
})
.WithName("GetPersona")
.WithOpenApi();

app.MapGet("/personas", () =>
{
    PersonaService service = new PersonaService();

    return service.GetAll();
})
.WithName("GetAllPersonas")
.WithOpenApi();

app.MapPost("/personas", (Persona entity) =>
{
    PersonaService service = new PersonaService();

    service.Add(entity);
})
.WithName("AddPersona")
.WithOpenApi();

app.MapPut("/personas", (Persona entity) =>
{
    PersonaService service = new PersonaService();

    service.Update(entity);
})
.WithName("UpdatePersona")
.WithOpenApi();

app.MapDelete("/personas/{id}", (int id) =>
{
    PersonaService service = new PersonaService();

    service.Delete(id);
})
.WithName("DeletePersona")
.WithOpenApi();

//Planes
app.MapGet("/planes/{id}", (int id) =>
{
    PlanService service = new PlanService();

    return service.Get(id);
})
.WithName("GetPlan")
.WithOpenApi();

app.MapGet("/planes", () =>
{
    PlanService service = new PlanService();

    return service.GetAll();
})
.WithName("GetAllPlanes")
.WithOpenApi();

app.MapPost("/planes", (Plan entity) =>
{
    PlanService service = new PlanService();

    service.Add(entity);
})
.WithName("AddPlan")
.WithOpenApi();

app.MapPut("/planes", (Plan entity) =>
{
    PlanService service = new PlanService();

    service.Update(entity);
})
.WithName("UpdatePlan")
.WithOpenApi();

app.MapDelete("/planes/{id}", (int id) =>
{
    PlanService service = new PlanService();

    service.Delete(id);
})
.WithName("DeletePlan")
.WithOpenApi();

//Especialidades
app.MapGet("/especialidades/{id}", (int id) =>
{
    EspecialidadService service = new EspecialidadService();

    return service.Get(id);
})
.WithName("GetEspecialidad")
.WithOpenApi();

app.MapGet("/especialidades", () =>
{
    EspecialidadService service = new EspecialidadService();

    return service.GetAll();
})
.WithName("GetAllEspecialidades")
.WithOpenApi();

app.MapPost("/especialidades", (Especialidad entity) =>
{
    EspecialidadService service = new EspecialidadService();

    service.Add(entity);
})
.WithName("AddEspecialidad")
.WithOpenApi();

app.MapPut("/especialidades", (Especialidad entity) =>
{
    EspecialidadService service = new EspecialidadService();

    service.Update(entity);
})
.WithName("UpdateEspecialidad")
.WithOpenApi();

app.MapDelete("/especialidades/{id}", (int id) =>
{
    EspecialidadService service = new EspecialidadService();

    service.Delete(id);
})
.WithName("DeleteEspecialidad")
.WithOpenApi();
//app.MapGet("/", () => "Hello World!");

app.Run();
