using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacturaTallerMVC.Models
{
    public class Factura
    {
        [Key]
        public int IdFactura { get; set; }

        // Llaves Foráneas
        public int? ClienteId { get; set; } // Llave foránea
        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; } // Navegación

        public int? CocheId { get; set; } // Llave foránea
        [ForeignKey("CocheId")]
        public Coche? Coche { get; set; } // Navegación

        public int? RecambioId { get; set; } // Llave foránea
        [ForeignKey("RecambioId")]
        public Recambio? Recambio { get; set; } // Navegación

        // Recambios en la factura
        public int? Piezas { get; set; }
        public int? TotalPiezas { get; set; }

        // Trabajos en la factura
        public string? Trabajos { get; set; }
        public int? HorasTaller { get; set; }
        public int? TotalHoras { get; set; }

        // Total de La factura
        public int Pvp { get; set; }

        // Fecha de la factura
        public DateTime Fecha { get; set; }
    }
}
