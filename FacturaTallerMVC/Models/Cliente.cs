using System.ComponentModel.DataAnnotations.Schema;

namespace FacturaTallerMVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
      
        
    }
}