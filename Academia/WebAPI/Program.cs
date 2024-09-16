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
    PersonaService personaService = new PersonaService();

    return personaService.Get(id);
})
.WithName("GetPersona")
.WithOpenApi();

app.MapGet("/personas", () =>
{
    PersonaService personaService = new PersonaService();

    return personaService.GetAll();
})
.WithName("GetAllPersonas")
.WithOpenApi();

app.MapPost("/personas", (Persona persona) =>
{
    PersonaService personaService = new PersonaService();

    personaService.Add(persona);
})
.WithName("AddPersona")
.WithOpenApi();

app.MapPut("/personas", (Persona persona) =>
{
    PersonaService personaService = new PersonaService();

    personaService.Update(persona);
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

//Planes
app.MapGet("/planes/{id}", (int id) =>
{
    PlanService planService = new PlanService();

    return planService.Get(id);
})
.WithName("GetPlan")
.WithOpenApi();

app.MapGet("/planes", () =>
{
    PlanService planService = new PlanService();

    return planService.GetAll();
})
.WithName("GetAllPlanes")
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
//app.MapGet("/", () => "Hello World!");

app.Run();
