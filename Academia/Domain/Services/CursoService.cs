using Domain.Models;
using Domain.Context;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class CursoService
    {
        public void Add(Curso curso)
        {
            using var context = new AcademiaContext();

            context.Attach(curso.Comision);
            context.Attach(curso.Materia);
            context.Cursos.Add(curso);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();

            Curso? cursoToDelete = context.Cursos.Find(id);

            if (cursoToDelete != null)
            {
                context.Cursos.Remove(cursoToDelete);
                context.SaveChanges();
            }
        }

        public Curso? Get(int id)
        {
            using var context = new AcademiaContext();

            return context.Cursos
                .Include(c => c.Materia)
                    .ThenInclude(materia => materia.Plan)
                        .ThenInclude(plan => plan.Especialidad)
                 .Include(c => c.Comision)
                    .ThenInclude(comision => comision.Plan)
                        .ThenInclude(plan => plan.Especialidad)
                .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Curso> GetAll()
        {
            using var context = new AcademiaContext();

            return context.Cursos
                .Include(c => c.Materia)
                    .ThenInclude(materia => materia.Plan)
                        .ThenInclude(plan => plan.Especialidad)
                 .Include(c => c.Comision)
                    .ThenInclude(comision => comision.Plan)
                        .ThenInclude(plan => plan.Especialidad)
                .ToList();
        }

        public void Update(Curso curso)
        {
            using var context = new AcademiaContext();

            Curso? cursoToUpdate = context.Cursos.Find(curso.Id);

            if (cursoToUpdate != null)
            {
                cursoToUpdate.Anio_Calendario = curso.Anio_Calendario;
                cursoToUpdate.Cupo = curso.Cupo;
                cursoToUpdate.Materia = curso.Materia;
                cursoToUpdate.Comision = curso.Comision;

                context.SaveChanges();
            }
        }

    }
}
