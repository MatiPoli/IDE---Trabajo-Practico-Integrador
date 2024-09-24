using Domain.Models;
using Domain.Context;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class Docentes_CursosService
    {
        public void Add(Docente_Curso docentes_cursos)
        {
            using var context = new AcademiaContext();

            context.Attach(docentes_cursos.Curso);
            context.Attach(docentes_cursos.Docente);
            context.Docentes_Cursos.Add(docentes_cursos);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new AcademiaContext();

            Docente_Curso? docentes_cursosToDelete = context.Docentes_Cursos.Find(id);

            if (docentes_cursosToDelete != null)
            {
                context.Docentes_Cursos.Remove(docentes_cursosToDelete);
                context.SaveChanges();
            }
        }
        public Docente_Curso? Get(int id)
        {
            using var context = new AcademiaContext();

            return context.Docentes_Cursos
                .Include(dc => dc.Curso)
                    .ThenInclude(curso => curso.Materia)
                        .ThenInclude(materia=> materia.Plan)
                            .ThenInclude(plan=> plan.Especialidad)
                .Include(dc => dc.Curso)
                    .ThenInclude(curso => curso.Comision)
                .Include(dc => dc.Docente)
                .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Docente_Curso> GetAll()
        {
            using var context = new AcademiaContext();

            return context.Docentes_Cursos
                .Include(dc => dc.Curso)
                    .ThenInclude(curso => curso.Materia)
                        .ThenInclude(materia => materia.Plan)
                            .ThenInclude(plan => plan.Especialidad)
                .Include(dc => dc.Curso)
                    .ThenInclude(curso => curso.Comision)
                .Include(dc => dc.Docente)
                .ToList();
        }

        public void Update(Docente_Curso docentes_Cursos)
        {
            using var context = new AcademiaContext();

            Docente_Curso? docentes_CursosToUpdate = context.Docentes_Cursos.Find(docentes_Cursos.Id);

            if (docentes_CursosToUpdate != null)
            {
                docentes_CursosToUpdate.Curso = docentes_Cursos.Curso;
                docentes_CursosToUpdate.Docente = docentes_Cursos.Docente;
                docentes_CursosToUpdate.Cargo = docentes_Cursos.Cargo;
                context.SaveChanges();
            }
        }
    }
}