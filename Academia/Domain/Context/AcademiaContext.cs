using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace Domain.Context
{
    internal class AcademiaContext : DbContext
    {
        internal DbSet<Usuario> Usuarios { get; set; }
        internal DbSet<Plan> Planes { get; set; }
        internal DbSet<Especialidad> Especialidades { get; set; }
        internal DbSet<Materia> Materias { get; set; }
        internal DbSet<Curso> Cursos { get; set; }
        internal DbSet<Comision> Comisiones { get; set; }
        internal DbSet<Docente_Curso> Docentes_Cursos { get; set; }
        internal DbSet<Inscripcion> Inscripciones { get; set; }


        internal AcademiaContext()
        {
            //this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            this.EnsureAdminCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Academia;Integrated Security=true");
            optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
                .HasOne(c => c.Materia)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Curso>()
                .HasOne(c => c.Comision)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Materia>()
                .HasOne(m => m.Plan)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Docente_Curso>()
                .HasOne(dc => dc.Curso)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Docente_Curso>()
                .HasOne(dc => dc.Docente)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Inscripcion>()
                .HasOne(i => i.Alumno)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Inscripcion>()
                .HasOne(i => i.Curso)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            
        }

        private void EnsureAdminCreated()
        {
            Usuario admin = Usuarios.FirstOrDefault(p => p.Tipo_Persona == "Admin");

            if (admin == null)
            {
                admin = new Usuario
                {
                    Email = "admin@admin.com",
                    Clave = "admin",
                    Nombre = "admin",
                    Apellido = "admin",
                    Direccion = "admin",
                    Telefono = "admin",
                    Fecha_Nac = "01/01/2000",
                    Legajo = "11111",
                    Tipo_Persona = "Admin"
                };
                Console.WriteLine("/n/nSe creó el usuario 'Admin'./nEmail: 'admin@admin.com'/nClave: 'admin'/n/n");
                this.Usuarios.Add(admin);
                this.SaveChanges();
            }
            else
            {
                Console.WriteLine("/n/nUsuario 'Admin' ya existe./nEmail: 'admin@admin.com'/nClave: 'admin'/n/n");
            }
        }
    }
}
