using Domain.Models;
using Domain.Context;

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

            return context.Comisiones.Find(id);
        }

        public IEnumerable<Comision> GetAll()
        {
            using var context = new AcademiaContext();

            return context.Comisiones.ToList();
        }

        public void Update(Comision comision)
        {
            using var context = new AcademiaContext();

            Comision? comisionToUpdate = context.Comisiones.Find(comision.Id);

            if (comisionToUpdate != null)
            {
                comisionToUpdate.Descripcion = comision.Descripcion;
                comisionToUpdate.anio = comision.Anio;
                comisionToUpdate.Plan = comision.Plan;
                context.SaveChanges();
            }
        }
    }
}