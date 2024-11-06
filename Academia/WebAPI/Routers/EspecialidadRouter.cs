using Domain.Models;
using Domain.Services;

namespace WebAPI.Routers
{
    public class EspecialidadRouter
    {
        public static void Map(WebApplication app)
        {
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
        }

    }
}
