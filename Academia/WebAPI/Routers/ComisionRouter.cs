using Domain.Models;
using Domain.Services;

namespace WebAPI.Routers
{
    public class ComisionRouter
    {
        public static void Map(WebApplication app)
        {
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
        }
    }
}
