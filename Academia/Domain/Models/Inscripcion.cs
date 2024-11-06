namespace Domain.Models
{
    public class Inscripcion
    {
        public int Id { get; set; }  
        public string Condicion { get; set; } = "Sin Condición";
        public int Nota { get; set; } = 0;
        public Usuario Alumno  { get; set; } = null!;
        public Curso Curso { get; set; } = null!;
    }
}
