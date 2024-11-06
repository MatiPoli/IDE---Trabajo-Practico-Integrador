namespace Domain.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Clave { get; set; } = null!;


        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Fecha_Nac { get; set; } = null!;
        public string Legajo { get; set; } = "Sin Legajo";

        public string Tipo_Persona { get; set; } = "Alumno"; 
        //public Plan Plan { get; set; } = null!; // Da problemas
    }
}
