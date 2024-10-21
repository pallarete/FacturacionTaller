using Microsoft.EntityFrameworkCore;
namespace FacturaTallerMVC.Data
{
    public class DataContext :DbContext
    {
          public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //Sintaxis indiferente del motor de base de datos
        public DbSet<Models.OrdenTrabajo> Facturas { get; set; }
        public DbSet<Models.Cliente> Clientes { get; set; }
        public DbSet<Models.Recambio> Recambios { get; set; }
        public DbSet<Models.Coche> Coches { get; set; }
    }
}