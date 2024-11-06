using Domain.Models;
using Domain.Services;

namespace WebAPI.Routers
{
    public class IncripcionRouter
    {
        public static void Map(WebApplication app)
        {
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

            app.MapGet("/inscripciones/alumno/{id}", (int id) =>
            {
                InscripcionService service = new InscripcionService();

                return service.GetAllByAlumno(id);
            })
            .WithName("GetAllInscripcionesByAlumno")
            .WithOpenApi();

            app.MapGet("/inscripciones/curso/{id}", (int id) =>
            {
                InscripcionService service = new InscripcionService();

                return service.GetAllByCurso(id);
            })
            .WithName("GetAllInscripcionesByCurso")
            .WithOpenApi();

            app.MapGet("/inscripciones/cursosWithCupo/{id}", (int id) =>
            {
                InscripcionService service = new InscripcionService();

                return service.GetAllWithCupos(id);
            })
            .WithName("GetAllCursosWithCupo")
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

            app.MapGet("/inscripciones/thereIsCupo/{id}", (int id) =>
            {
                InscripcionService service = new InscripcionService();

                return service.ThereIsCupo(id);
            })
            .WithName("ThereIsCupo")
            .WithOpenApi();

            app.MapGet("/inscripciones/IsAlumnoEnrolledInCurso/{alumnoId}/{cursoId}", (int alumnoId, int cursoId) =>
            {
                InscripcionService service = new InscripcionService();

                return service.IsAlumnoEnrolledInCurso(alumnoId, cursoId);
            })
            .WithName("IsAlumnoEnrolledInCurso")
            .WithOpenApi();
        }
    }
}
