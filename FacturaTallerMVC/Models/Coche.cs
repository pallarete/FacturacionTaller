using System.ComponentModel.DataAnnotations;

namespace FacturaTallerMVC.Models
{
    public class Coche
    {
        
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Marca { get; set; } =string.Empty;
        public string Modelo { get; set; } =string.Empty;
        public string Combustible { get; set; } =string.Empty;
        public int Kilometros { get; set; }

        
    }
}