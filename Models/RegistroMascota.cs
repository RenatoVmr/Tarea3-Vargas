namespace Tarea3VRD.Models
{
    public class RegistroMascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Propietario { get; set; }
    }
}