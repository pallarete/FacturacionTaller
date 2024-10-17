using System.ComponentModel.DataAnnotations;

namespace FacturaTallerMVC.Models
{
    public class Coche
    {
        [Key]
        public int IdMatricula { get; set; }
        public required string Marca { get; set; } 
        public required string Modelo { get; set; } 
        public required string Combustible { get; set; } 
        public required int Kilometros { get; set; }

        
    }
}