using EcommerceWeb.Entidades;
using EcommerceWeb.Repositorios.Implementaciones;
using ECommerceWeb.DataAccess.Data;

namespace EcommerceWeb.Aplicacion
{
    public class EjerciciosParte02
    {
        public static void Ejecutar()
        {
            
            var contexto = new EcommerceDbContext();
            var repoVentas = new VentaRepositorio(contexto);
            try
            {
                
                repoVentas.IniciarTransaccion();
                var ventas = new Venta()
                {
                    ClienteId = 1,
                    NumeroFactura = repoVentas.Correlativo(),
                    FechaVenta = DateTime.Now
                };

                repoVentas.AgregarDetalle(new()
                {
                    ProductoId = 1,
                    Cantidad = 2,
                    PrecioUnitario = 3500,
                    Total = 7000,
                    Venta = ventas
                });
                repoVentas.AgregarDetalle(new()
                {
                    ProductoId = 2,
                    Cantidad = 3,
                    PrecioUnitario = 2000,
                    Total = 6000,
                    Venta = ventas
                });

                //Calculamos el total venta
                //ventas.TotalVenta=ventas.Detalles.Sum(x => x.Cantidad*x.Total);
                ventas.TotalVenta = 6000;
                repoVentas.Insertar(ventas);
                repoVentas.FinalizarTransaccion();
            }
            catch (Exception ex)
            {
                repoVentas.CancelarTransaccion();
                Console.WriteLine(ex.ToString());
            }
            
            //Mostrar todas las ventas
            repoVentas.Listar().ForEach(x => Console.WriteLine(x));
            //Mostrar la venta seleccionada incluido el cliente 
            Console.WriteLine("Seleccione una venta a mostrar");
            var ObtenerVenta = repoVentas.MostrarVenta(int.Parse(Console.ReadLine()!));
            Console.WriteLine($"{ObtenerVenta!.NumeroFactura} | {ObtenerVenta.FechaVenta} | {ObtenerVenta.TotalVenta} | {ObtenerVenta.Cliente!.Nombre}");
            //Mostrar cantidad de productos de la venta seleccionada
            Console.WriteLine($"La cantidad de productos de la venta{ObtenerVenta.Id} son: {ObtenerVenta.Detalles.Count()}");
            repoVentas.Separador();
            //Mostrar todos los produtos de dicha venta
            ObtenerVenta.Detalles.ForEach(x =>
            {
                Console.WriteLine($"{x.Id}: | {x.VentaId} | {x.Producto!.Nombre} | {x.PrecioUnitario} | {x.Cantidad}");
            });  











        }
    }
}
