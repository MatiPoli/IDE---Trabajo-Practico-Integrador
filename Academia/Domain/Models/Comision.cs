namespace Domain.Models
{
    public class Comision
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Anio { get; set; }
        public Plan Plan { get; set; } = null!;
    }
}