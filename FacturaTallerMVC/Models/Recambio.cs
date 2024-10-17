using System.ComponentModel.DataAnnotations;

namespace FacturaTallerMVC.Models
{
    public class Recambio
    {
        [Key]
        public int IdRecambio { get; set; } 
        public required string Nombre { get; set; }
        public required string Descripcion { get; set; }
        public required int Precio { get; set; }

    }
}