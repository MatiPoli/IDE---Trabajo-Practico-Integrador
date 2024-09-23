using Domain.Models;
using Domain.Context;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class PersonaService
    {
        public void Add(Persona persona)
        {
            using var context = new AcademiaContext();

            context.Attach(persona.Plan);
            context.Personas.Add(persona);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();

            Persona? personaToDelete = context.Personas.Find(id);

            if (personaToDelete != null)
            {
                context.Personas.Remove(personaToDelete);
                context.SaveChanges();
            }
        }

        public Persona? Get(int id)
        {
            using var context = new AcademiaContext();

            return context.Personas
                .Include(p => p.Plan)
                    .ThenInclude(plan => plan.Especialidad)
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Persona> GetAll()
        {
            using var context = new AcademiaContext();

            return context.Personas
                .Include(p => p.Plan)
                    .ThenInclude(plan => plan.Especialidad)
                .ToList();
        }

        public void Update(Persona persona)
        {
            using var context = new AcademiaContext();

            Persona? personaToUpdate = context.Personas.Find(persona.Id);

            if (personaToUpdate != null)
            {
                personaToUpdate.Nombre = persona.Nombre;
                personaToUpdate.Apellido = persona.Apellido;
                personaToUpdate.Direccion = persona.Direccion;
                personaToUpdate.Email = persona.Email;
                personaToUpdate.Telefono = persona.Telefono;
                personaToUpdate.Fecha_Nac = persona.Fecha_Nac;
                personaToUpdate.Legajo = persona.Legajo;
                personaToUpdate.Plan = persona.Plan;

                context.SaveChanges();
            }
        }

    }
}
