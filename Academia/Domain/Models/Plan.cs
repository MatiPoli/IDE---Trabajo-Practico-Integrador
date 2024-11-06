namespace Domain.Models
{
    public class Plan
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;

        public Especialidad Especialidad { get; set; } = null!;
    }
}
