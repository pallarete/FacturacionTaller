using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FacturaTallerMVC.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        
        //Referencio al coche
        [ForeignKey ("IdMatricula")]
        public List<Coche>? Matricula { get; set;}

        public required string Nombre { get; set; } 
        public required string Apellidos { get; set; } 
    }
}