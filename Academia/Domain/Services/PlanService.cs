using Domain.Models;
using Domain.Context;

namespace Domain.Services
{
    public class PlanService
    {
        public void Add(Plan plan)
        {
            using var context = new AcademiaContext();

            context.Planes.Add(plan);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();

            Plan? planToDelete = context.Planes.Find(id);

            if (planToDelete != null)
            {
                context.Planes.Remove(planToDelete);
                context.SaveChanges();
            }
        }

        public Plan? Get(int id)
        {
            using var context = new AcademiaContext();

            return context.Planes.Find(id);
        }

        public IEnumerable<Plan> GetAll()
        {
            using var context = new AcademiaContext();

            return context.Planes.ToList();
        }

        public void Update(Plan plan)
        {
            using var context = new AcademiaContext();

            Plan? planToUpdate = context.Planes.Find(plan.Id);

            if (planToUpdate != null)
            {
                planToUpdate.Descripcion = plan.Descripcion;
                

                context.SaveChanges();
            }
        }

    }
}
