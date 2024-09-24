using Domain.Models;
using Domain.Context;

namespace Domain.Services
{
    public class Docentes_CursosService
    {
        public void Add(Docentes_Cursos docentes_cursos)
        {
            using var context = new AcademiaContext();

            context.Docentes_CursosSet.Add(docentes_cursos);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new AcademiaContext();

            Docentes_Cursos? docentes_cursosToDelete = context.Docentes_CursosSet.Find(id);

            if (comisionToDelete != null)
            {
                context.Docentes_CursosSet.Remove(docentes_cursosToDelete);
                context.SaveChanges();
            }
        }
        public Docentes_Cursos? Get(int id)
        {
            using var context = new AcademiaContext();

            return context.Docentes_CursosSet
                .Include(dc => dc.Curso)
                    .ThenInclude(curso=> curso.Materia)
                        .ThenInclude(materia=> materia.Plan)
                            .ThenInclude(plan=> plan.Especialidad)
                    .ThenInclude(curso=> curso.Comision)
                .Include(dc => dc.Docente)
                .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Docentes_Cursos> GetAll()
        {
            using var context = new AcademiaContext();

            return context.Docentes_CursosSet
                .Include(dc => dc.Curso)

                    .ThenInclude(curso => curso.Materia)
                        .ThenInclude(materia => materia.Plan)
                            .ThenInclude(plan => plan.Especialidad)
                    .ThenInclude(curso => curso.Comision)

                .Include(dc => dc.Docente)
                
                .ToList();
        }

        public void Update(Docentes_Cursos docentes_Cursos)
        {
            using var context = new AcademiaContext();

            Docentes_Cursos? docentes_CursosToUpdate = context.Docentes_CursosSet.Find(comision.Id);

            if (comisionToUpdate != null)
            {
                docentes_CursosToUpdate.Curso = docentes_Cursos.Curso;
                docentes_CursosToUpdate.Docente = docentes_Cursos.Docente;
                docentes_CursosToUpdate.Cargo = docentes_Cursos.Cargo;
                context.SaveChanges();
            }
        }
    }
}