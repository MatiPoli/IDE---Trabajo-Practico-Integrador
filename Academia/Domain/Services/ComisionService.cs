using Domain.Models;
using Domain.Context;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class ComisionService
    {
        public void Add(Comision comision)
        {
            using var context = new AcademiaContext();

            context.Comisiones.Add(comision);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new AcademiaContext();

            Comision? comisionToDelete = context.Comisiones.Find(id);

            if (comisionToDelete != null)
            {
                context.Comisiones.Remove(comisionToDelete);
                context.SaveChanges();
            }
        }
        public Comision? Get(int id)
        {
            using var context = new AcademiaContext();

            return context.Comisiones
                .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Comision> GetAll()
        {
            using var context = new AcademiaContext();

            return context.Comisiones
                .ToList();
        }

        public void Update(Comision comision)
        {
            using var context = new AcademiaContext();

            Comision? comisionToUpdate = context.Comisiones.Find(comision.Id);

            if (comisionToUpdate != null)
            {
                comisionToUpdate.Descripcion = comision.Descripcion;
                comisionToUpdate.Anio = comision.Anio;
                context.SaveChanges();
            }
        }
    }
}