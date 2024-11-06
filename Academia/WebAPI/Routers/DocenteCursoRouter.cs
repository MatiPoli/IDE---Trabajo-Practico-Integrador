using Domain.Models;
using Domain.Services;

namespace WebAPI.Routers
{
    public class DocenteCursoRouter
    {
        public static void Map(WebApplication app)
        {
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

            app.MapGet("/docentes_cursos/docente/{id}", (int id) =>
            {
                Docentes_CursosService service = new Docentes_CursosService();

                return service.GetAllByDocente(id);
            })
            .WithName("GetAllDocentes_CursosByDocente")
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
        }
    }
}
