using Domain.Models;
using Domain.Services;

namespace WebAPI.Routers
{
    public class MateriaRouter
    {
        public static void Map(WebApplication app)
        {
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
        }
    }
}
