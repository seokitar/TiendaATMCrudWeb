using EcommerceWeb.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWeb.Repositorios.Interfaces
{
    public interface IVentaRepositorio : IRepositorioBase<Venta>
    {
        //Realizando un interface personalizado para ventas adicional al IRepositorioBase
        //El fin de esto es insertar una venta completa usando Venta y VentaDetalle
        Venta? MostrarVenta(int ventaId);
        List<VentaDetalle> ListarDetalles(int ventaId);
        void IniciarTransaccion();
        void AgregarDetalle(VentaDetalle ventaDetalle);
        void FinalizarTransaccion();
        void CancelarTransaccion();

        string Correlativo();
      
    }
}
