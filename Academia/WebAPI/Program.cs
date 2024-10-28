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

// Comisiones
app.MapGet("/comisiones/{id}", (int id) =>
{
    ComisionService service = new ComisionService();

    return service.Get(id);
})
.WithName("GetComision")
.WithOpenApi();

app.MapGet("/comisiones", () =>
{
    ComisionService service = new ComisionService();

    return service.GetAll();
})
.WithName("GetAllComisiones")
.WithOpenApi();

app.MapPost("/comisiones", (Comision entity) =>
{
    ComisionService service = new ComisionService();

    service.Add(entity);
})
.WithName("AddComision")
.WithOpenApi();

app.MapPut("/comisiones", (Comision entity) =>
{
    ComisionService service = new ComisionService();

    service.Update(entity);
})
.WithName("UpdateComision")
.WithOpenApi();

app.MapDelete("/comisiones/{id}", (int id) =>
{
    ComisionService service = new ComisionService();

    service.Delete(id);
})
.WithName("DeleteComision")
.WithOpenApi();

// Materias
app.MapGet("/materias/{id}", (int id) =>
{
    MateriaService service = new MateriaService();

    return service.Get(id);
})
.WithName("GetMateria")
.WithOpenApi();

app.MapGet("/materias", () =>
{
    MateriaService service = new MateriaService();

    return service.GetAll();
})
.WithName("GetAllMaterias")
.WithOpenApi();

app.MapPost("/materias", (Materia entity) =>
{
    MateriaService service = new MateriaService();

    service.Add(entity);
})
.WithName("AddMateria")
.WithOpenApi();

app.MapPut("/materias", (Materia entity) =>
{
    MateriaService service = new MateriaService();

    service.Update(entity);
})
.WithName("UpdateMateria")
.WithOpenApi();

app.MapDelete("/materias/{id}", (int id) =>
{
    MateriaService service = new MateriaService();

    service.Delete(id);
})
.WithName("DeleteMateria")
.WithOpenApi();

// Cursos
app.MapGet("/cursos/{id}", (int id) =>
{
    CursoService service = new CursoService();

    return service.Get(id);
})
.WithName("GetCurso")
.WithOpenApi();

app.MapGet("/cursos", () =>
{
    CursoService service = new CursoService();

    return service.GetAll();
})
.WithName("GetAllCursos")
.WithOpenApi();

app.MapPost("/cursos", (Curso entity) =>
{
    CursoService service = new CursoService();

    service.Add(entity);
})
.WithName("AddCurso")
.WithOpenApi();

app.MapPut("/cursos", (Curso entity) =>
{
    CursoService service = new CursoService();

    service.Update(entity);
})
.WithName("UpdateCurso")
.WithOpenApi();

app.MapDelete("/cursos/{id}", (int id) =>
{
    CursoService service = new CursoService();

    service.Delete(id);
})
.WithName("DeleteCurso")
.WithOpenApi();

// Docentes_Cursos
app.MapGet("/docentes_cursos/{id}", (int id) =>
{
    Docentes_CursosService service = new Docentes_CursosService();

    return service.Get(id);
})
.WithName("GetDocente_Curso")
.WithOpenApi();

app.MapGet("/docentes_cursos", () =>
{
    Docentes_CursosService service = new Docentes_CursosService();

    return service.GetAll();
})
.WithName("GetAllDocentes_Cursos")
.WithOpenApi();

app.MapPost("/docentes_cursos", (Docente_Curso entity) =>
{
    Docentes_CursosService service = new Docentes_CursosService();

    service.Add(entity);
})
.WithName("AddDocente_Curso")
.WithOpenApi();

app.MapPut("/docentes_cursos", (Docente_Curso entity) =>
{
    Docentes_CursosService service = new Docentes_CursosService();

    service.Update(entity);
})
.WithName("UpdateDocente_Curso")
.WithOpenApi();

app.MapDelete("/docentes_cursos/{id}", (int id) =>
{
    Docentes_CursosService service = new Docentes_CursosService();

    service.Delete(id);
})
.WithName("DeleteDocente_Curso")
.WithOpenApi();

// Inscripciones
app.MapGet("/inscripciones/{id}", (int id) =>
{
    InscripcionService service = new InscripcionService();

    return service.Get(id);
})
.WithName("GetInscripcion")
.WithOpenApi();

app.MapGet("/inscripciones", () =>
{
    InscripcionService service = new InscripcionService();

    return service.GetAll();
})
.WithName("GetAllInscripciones")
.WithOpenApi();

app.MapPost("/inscripciones", (Inscripcion entity) =>
{
    InscripcionService service = new InscripcionService();

    service.Add(entity);
})
.WithName("AddInscripcion")
.WithOpenApi();

app.MapPut("/inscripciones", (Inscripcion entity) =>
{
    InscripcionService service = new InscripcionService();

    service.Update(entity);
})
.WithName("UpdateInscripcion")
.WithOpenApi();

app.MapDelete("/inscripciones/{id}", (int id) =>
{
    InscripcionService service = new InscripcionService();

    service.Delete(id);
})
.WithName("DeleteInscripcion")
.WithOpenApi();

//app.MapGet("/", () => "Hello World!");

app.Run();
