namespace Domain.Models
{
    public class Docentes_Cursos
    {
        public int Id { get; set; }
        public Curso Curso { get; set; }
        public Docente Docente { get; set; }
        public string Cargo { get; set; }
    }
}