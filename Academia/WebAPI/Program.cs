using Domain.Services;
using Domain.Models;
using WebAPI.Routers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy =>
        {
            policy.AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //Falta configurar de manera correcta        
    app.UseHttpLogging();
}

app.UseCors("AllowAllOrigins");


app.UseHttpsRedirection();

UsuarioRouter.Map(app);
PlanRouter.Map(app);
EspecialidadRouter.Map(app);
ComisionRouter.Map(app);
MateriaRouter.Map(app);
CursoRouter.Map(app);
DocenteCursoRouter.Map(app);
IncripcionRouter.Map(app);

//app.MapGet("/", () => "Hello World!");

app.Run();
