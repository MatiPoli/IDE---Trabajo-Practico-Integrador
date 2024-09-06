﻿using Domain.Models;
using Domain.Context;

namespace Domain.Services
{
    internal class PersonaService
    {
        public void Add(Persona persona)
        {
            using var context = new AcademiaContext();

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

            return context.Personas.Find(id);
        }

        public IEnumerable<Persona> GetAll()
        {
            using var context = new AcademiaContext();

            return context.Personas.ToList();
        }

        public void Update(Persona persona)
        {
            using var context = new AcademiaContext();

            Persona? personaToUpdate = context.Personas.Find(persona.Id);

            if (personaToUpdate != null)
            {
                personaToUpdate.Nombre = persona.Nombre;
                context.SaveChanges();
            }
        }
    }
}
