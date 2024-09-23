using Domain.Models;
using Domain.Context;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class MateriaService
    {
        public void Add(Materia materia)
        {
            using var context = new AcademiaContext();

            context.Attach(materia.Plan);
            context.Materias.Add(materia);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();

            Materia? materiaToDelete = context.Materias.Find(id);

            if (materiaToDelete != null)
            {
                context.Materias.Remove(materiaToDelete);
                context.SaveChanges();
            }
        }

        public Materia? Get(int id)
        {
            using var context = new AcademiaContext();

            return context.Materias
                .Include(m => m.Plan)
                    .ThenInclude(plan => plan.Especialidad)
                .FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Materia> GetAll()
        {
            using var context = new AcademiaContext();

            return context.Materias
                .Include(m => m.Plan)
                    .ThenInclude(plan => plan.Especialidad)
                .ToList();
        }

        public void Update(Materia materia)
        {
            using var context = new AcademiaContext();

            Materia? materiaToUpdate = context.Materias.Find(materia.Id);

            if (materiaToUpdate != null)
            {
                materiaToUpdate.Descripcion = materia.Descripcion;
                materiaToUpdate.Hs_Semanales = materia.Hs_Semanales;
                materiaToUpdate.Hs_Totales = materia.Hs_Totales;
                materiaToUpdate.Plan = materia.Plan;

                context.SaveChanges();
            }
        }

    }
}
