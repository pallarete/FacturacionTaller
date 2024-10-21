using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacturaTallerMVC.Models
{
    public enum Combustible
    {
        Gasolina,
        Diesel,
        Hibrido,
        Eléctrico
    }
    public class Coche
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCoche { get; set; }

        [Required]
        public string? Matricula { get; set; } // Cambiar a string para que sea alfanumérico
        
        [Required]
        public required string Marca { get; set; }
        
        [Required]
        public required string Modelo { get; set; }
        
        public Combustible Combustible { get; set; } // Enum Combustible

        // Método para procesar el tipo de combustible
        public string ProcesarCombustible()
        {
            string resultado = Combustible switch
            {
                Combustible.Gasolina => "Gasolina.",
                Combustible.Diesel => "Diesel.",
                Combustible.Hibrido => "Híbrido.",
                Combustible.Eléctrico => "Eléctrico.",
                _ => "Tipo de combustible no reconocido.",
            };
            return resultado;
        }

        public required int Kilometros { get; set; }
        public required int AñoFabrica { get; set; }

        // Llave foránea opcional para el cliente
        public int? ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; } // Propiedad de navegación hacia el cliente
    }
}
