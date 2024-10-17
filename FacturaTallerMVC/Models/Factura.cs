using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FacturaTallerMVC.Models
{
    public class Factura
    {
        [Key]
        public int IdFactura { get; set; }

        //Llaves Foraneas
        [ForeignKey("IdCliente")]
        public List<Cliente>? Cliente { get; set; }

        [ForeignKey("IdMatricula")]
        public List<Coche>? Matricula  { get; set; }

        [ForeignKey("IdRecambio")]
        public List<Recambio>? Recambio { get; set; }

        //Recambios en la factura
        public int? UnidadesRecambio { get; set; }

        public int? TotalRecambio { get; set; }

        //Trabajos en la factura
        public string? Trabajo { get; set; }

        public int? UnidadesTrabajo { get; set; }
        public int? TotalTrabajo { get; set; }

        //Total de La factura
        public int Pvp { get; set; }

        //Fecha de la factura
        public DateTime Fecha { get; set; }
    }
}