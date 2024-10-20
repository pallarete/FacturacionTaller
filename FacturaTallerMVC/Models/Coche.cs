using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacturaTallerMVC.Models
{
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
        public enum Combustible
        {
            Gasolina,
            Diesel,
            Hibrido,
            Electrico
        }
        public required int Kilometros { get; set; }
        public required int AñoFabricacion { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "La matrícula no puede exceder los 10 caracteres.")]


        // Llave foránea opcional para el cliente
        public int? ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; } // Propiedad de navegación hacia el cliente
    }
}
