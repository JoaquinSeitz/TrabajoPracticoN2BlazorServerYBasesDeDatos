using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabajoPracticoN2BlazorServerYBasesDeDatos.Models
{
    public class Turno
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime FechaHora { get; set; }

        [Required]
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; }

        [Required]
        public int ServicioId { get; set; }
        [ForeignKey("ServicioId")]
        public Servicio? Servicio { get; set; }

        public string? Observaciones { get; set; }
    }
}