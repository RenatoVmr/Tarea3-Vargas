namespace Tarea3VRD.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty; // Ej: Perro, Gato, Ave...
        public int Edad { get; set; }
    }
}
