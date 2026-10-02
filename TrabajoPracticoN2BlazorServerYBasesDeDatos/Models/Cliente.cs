using System.ComponentModel.DataAnnotations;

namespace TrabajoPracticoN2BlazorServerYBasesDeDatos.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public string Apellido { get; set; } = string.Empty;
        public string? Telefono { get; set; }
        public string? Email { get; set; }

        public List<Turno> Turnos { get; set; } = new();
    }
}