namespace Domain.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Hs_Semanales { get; set; }
        public int Hs_Totales { get; set; }
        public Plan Plan { get; set; } = null!;
    }
}
