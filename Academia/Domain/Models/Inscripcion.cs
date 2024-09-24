namespace Domain.Models
{
    public class Inscripcion
    {
        public int Id { get; set; }  
        public string Condicion { get; set; } = null!;
        public int Nota { get; set; }
        public Persona Alumno  { get; set; } = null!;
        public Curso Curso { get; set; } = null!;
    }
}
