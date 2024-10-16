namespace FacturaTallerMVC.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public List<Cliente>? Clientes { get; set; }
        public List<Recambio>? Recambios { get; set; }
        public int Unidades { get; set; } 
        public int Pvp { get; set; } 
        public float Neto { get; set; } 
        public List<Coche>? Coches { get; set; }
        public string Trabajo { get; set; } = string.Empty;
        public DateOnly Fecha { get; set; }
    }
}