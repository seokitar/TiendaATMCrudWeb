using EcommerceWeb.Entidades;
using EcommerceWeb.Repositorios.Interfaces;
using ECommerceWeb.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWeb.Repositorios.Implementaciones
{
    public class VentaRepositorio : RepositorioBase<Venta>, IVentaRepositorio
    {
        public VentaRepositorio(EcommerceDbContext context) : base(context)
        {
        }

        public void AgregarDetalle(VentaDetalle ventaDetalle)
        {
            Context.Set<VentaDetalle>().Add(ventaDetalle);
            // Context.SaveChanges(); Obviamos el uso de Savechange para evitar que se guarde en la BD
            //ya que usaremos transacciones
        }

        public void CancelarTransaccion()
        {
            Context.Database.RollbackTransaction();
        }

        public void FinalizarTransaccion()
        {
            Context.Database.CommitTransaction();
            Context.SaveChanges();
        }

        public void IniciarTransaccion()
        {
            Context.Database.BeginTransaction();
        }

        public List<VentaDetalle> ListarDetalles(int ventaId)
        {
            return Context.Set<VentaDetalle>()
                .Where(x => x.Id == ventaId)
                .ToList();

        }

        public Venta? MostrarVenta(int ventaId)
        {
            return Context.Set<Venta>()
                .Include(x => x.Cliente)
                .Include(x => x.Detalles)
                .ThenInclude(y=>y.Producto)
                .FirstOrDefault(x => x.Id == ventaId);

        }
        public override void Insertar(Venta entidad)
        {
            Context.Set<Venta>().Add(entidad);
        }

        public string Correlativo()
        {
            var cantidad = Context.Set<Venta>().Count() + 1;
            return cantidad.ToString("0000");
        }
    }
}
