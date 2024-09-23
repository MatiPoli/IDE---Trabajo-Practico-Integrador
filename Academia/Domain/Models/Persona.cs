namespace Domain.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Fecha_Nac { get; set; } = null!;
        public string Legajo { get; set; } = null!;

        public Plan Plan { get; set; } = null!;
    }
}
