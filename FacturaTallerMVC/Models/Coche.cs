using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacturaTallerMVC.Models
{
    public class Coche
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCoche { get; set; }

        public required string Marca { get; set; } 
        public required string Modelo { get; set; } 
        public required string Combustible { get; set; } 
        public required int Kilometros { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "La matrícula no puede exceder los 10 caracteres.")]
        public string? Matricula { get; set; } // Cambiar a string para que sea alfanumérico


        // Llave foránea opcional para el cliente
        public int? ClienteId { get; set; } 
        
        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; } // Propiedad de navegación hacia el cliente
    }
}
