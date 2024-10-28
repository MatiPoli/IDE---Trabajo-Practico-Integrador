using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace Domain.Context
{
    internal class AcademiaContext : DbContext
    {
        internal DbSet<Persona> Personas { get; set; }
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
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Academia1;Integrated Security=true");
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

            modelBuilder.Entity<Persona>()
                .HasOne(p => p.Plan)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Comision>()
                .HasOne(c => c.Plan)
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
       
    }

}
