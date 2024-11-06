using Domain.Models;
using Domain.Services;

namespace WebAPI.Routers
{
    public class PlanRouter
    {
        public static void Map(WebApplication app)
        {
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
        }
    }
}
