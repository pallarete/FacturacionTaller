using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacturaTallerMVC.Models
{
    public class Recambio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRecambio { get; set; } 

        public required string Nombre { get; set; }
        public required string Descripcion { get; set; }

        // Cambiar a decimal para manejar precios con decimales
        public required decimal Precio { get; set; }

        // Opcional: Propiedad de navegación hacia las facturas
        public List<Factura>? Facturas { get; set; }
    }
}
