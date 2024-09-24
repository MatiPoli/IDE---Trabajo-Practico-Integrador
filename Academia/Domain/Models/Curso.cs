namespace Domain.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public int Anio_Calendario { get; set; }
        public int Cupo { get; set; }

        public Materia Materia { get; set; } = null!;
        public Comision Comision { get; set; } = null!;
    }
}
