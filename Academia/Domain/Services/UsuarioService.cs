using Domain.Models;
using Domain.Context;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services
{
    public class UsuarioService
    {
        public void Add(Usuario usuario)
        {
            using var context = new AcademiaContext();

            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();

            Usuario? usuarioToDelete = context.Usuarios.Find(id);

            if (usuarioToDelete != null)
            {
                context.Usuarios.Remove(usuarioToDelete);
                context.SaveChanges();
            }
        }

        public Usuario Login(string email, string clave)
        {
            using var context = new AcademiaContext();

            Usuario? usuario = context.Usuarios
                .FirstOrDefault(p => p.Email == email && p.Clave == clave);

            return usuario;
        }

        public Usuario? Get(int id)
        {
            using var context = new AcademiaContext();

            return context.Usuarios
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            using var context = new AcademiaContext();

            return context.Usuarios
                .ToList();
        }

        public IEnumerable<Usuario> GetAllDocentes()
        {
            using var context = new AcademiaContext();

            return context.Usuarios
                .Where(p => p.Tipo_Persona == "Docente")
                .ToList();
        }

        public IEnumerable<Usuario> GetAllAlumnos()
        {
            using var context = new AcademiaContext();

            return context.Usuarios
                .Where(p => p.Tipo_Persona == "Alumno")
                .ToList();
        }

        public void Update(Usuario usuario)
        {
            using var context = new AcademiaContext();

            Usuario? usuarioToUpdate = context.Usuarios.Find(usuario.Id);

            if (usuarioToUpdate != null)
            {
                usuarioToUpdate.Email = usuario.Email;
                usuarioToUpdate.Clave = usuario.Clave;

                usuarioToUpdate.Nombre = usuario.Nombre;
                usuarioToUpdate.Apellido = usuario.Apellido;
                usuarioToUpdate.Direccion = usuario.Direccion;
                usuarioToUpdate.Telefono = usuario.Telefono;
                usuarioToUpdate.Fecha_Nac = usuario.Fecha_Nac;
                usuarioToUpdate.Legajo = usuario.Legajo;
                usuarioToUpdate.Tipo_Persona = usuario.Tipo_Persona;

                context.SaveChanges();
            }
        }

    }
}
