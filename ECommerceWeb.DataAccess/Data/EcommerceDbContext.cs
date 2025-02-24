using EcommerceWeb.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceWeb.DataAccess.Data
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=MARSHELLA;Database=TiendaATM;Trusted_Connection=True;TrustServerCertificate=True");
            optionsBuilder.LogTo(Console.WriteLine);
        }

        public DbSet<Categoria> Categorias { get; set; } = default!;
        public DbSet<Cliente> Clientes { get; set; } = default!;
        public DbSet<Producto> Productos { get; set; } = default!;
        public DbSet<Venta> Ventas { get; set; } = default!;
        public DbSet<VentaDetalle> VentasDetalles { get; set; } = default!;








    }
}
