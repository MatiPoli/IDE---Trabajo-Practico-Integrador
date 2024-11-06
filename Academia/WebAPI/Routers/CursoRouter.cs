using Domain.Models;
using Domain.Services;

namespace WebAPI.Routers
{
    public class CursoRouter
    {
        public static void Map(WebApplication app)
        {
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
        }
    }
}
