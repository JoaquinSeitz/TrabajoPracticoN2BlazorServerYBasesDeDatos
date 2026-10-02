using System.ComponentModel.DataAnnotations;

namespace TrabajoPracticoN2BlazorServerYBasesDeDatos.Models
{
    public class Servicio
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        [Required]
        public decimal Precio { get; set; }

        public List<Turno> Turnos { get; set; } = new();
    }
}