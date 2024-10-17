using System.ComponentModel.DataAnnotations;

namespace FacturaTallerMVC.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        public required string Nombre { get; set; } 
        public required string Apellidos { get; set; } 

        // Propiedad de navegación: una lista de coches que pertenecen a este cliente
        public List<Coche>? Coches { get; set; } 
    }
}
