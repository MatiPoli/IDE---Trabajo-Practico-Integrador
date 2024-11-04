using Domain.Models;
using Domain.Context;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class InscripcionService
    {
        public void Add(Inscripcion inscripcion)
        {
            using var context = new AcademiaContext();

            context.Attach(inscripcion.Alumno);
            context.Attach(inscripcion.Curso);
            context.Inscripciones.Add(inscripcion);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new AcademiaContext();

            Inscripcion? inscripcionToDelete = context.Inscripciones.Find(id);

            if (inscripcionToDelete != null)
            {
                context.Inscripciones.Remove(inscripcionToDelete);
                context.SaveChanges();
            }
        }
        public Inscripcion? Get(int id)
        {
            using var context = new AcademiaContext();

            return context.Inscripciones
                .Include(i => i.Alumno)
                .Include(i => i.Curso)
                    .ThenInclude(curso => curso.Comision)
                .Include(i => i.Curso)
                    .ThenInclude(curso => curso.Materia)
                        .ThenInclude(materia => materia.Plan)
                                .ThenInclude(plan => plan.Especialidad)
                .FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<Inscripcion> GetAll()
        {
            using var context = new AcademiaContext();

            return context.Inscripciones
                .Include(i => i.Alumno)
                .Include(i => i.Curso)
                    .ThenInclude(curso => curso.Comision)
                .Include(i => i.Curso)
                    .ThenInclude(curso => curso.Materia)
                        .ThenInclude(materia => materia.Plan)
                            .ThenInclude(plan => plan.Especialidad)
                .ToList();
        }

        public void Update(Inscripcion inscripcion)
        {
            using var context = new AcademiaContext();

            Inscripcion? inscripcionToUpdate = context.Inscripciones.Find(inscripcion.Id);

            if (inscripcionToUpdate != null)
            {
                inscripcionToUpdate.Condicion = inscripcion.Condicion;
                inscripcionToUpdate.Nota = inscripcion.Nota;
                inscripcionToUpdate.Alumno = inscripcion.Alumno;
                inscripcionToUpdate.Curso = inscripcion.Curso;
                context.SaveChanges();
            }
        }

        public bool ThereIsCupo(int id)
        {
            using var context = new AcademiaContext();

            Curso? curso = context.Cursos.Find(id);
            return context.Inscripciones
                .Count(i => i.Curso.Id == curso.Id) < curso.Cupo;
        }
    }
}
