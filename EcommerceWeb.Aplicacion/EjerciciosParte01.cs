using EcommerceWeb.Entidades;
using EcommerceWeb.Repositorios.Implementaciones;
using ECommerceWeb.DataAccess.Data;

namespace EcommerceWeb.Aplicacion
{
    public class EjerciciosParte01
    {
        public static void Ejecutar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Trabajando con datos reales en la BD");
            //***************CATEGORÍAS***********
            //Instanciando objeto para insertar datos a clase categoría


            try
            {
                var cat1 = new Categoria();
                Console.WriteLine("Inserte nombre categoría");
                cat1.Nombre = Console.ReadLine();
                Console.WriteLine("Inserte descripcion de categoría");
                cat1.Descripcion = Console.ReadLine();
                //Instanciando Context en esta clase
                var contexto = new EcommerceDbContext();
                //Insertando objeto contexto en el repositorio deseado
                var repositorio = new CategoriaRepositorio(contexto);
                //Insertando objeto en el repositorio
                repositorio.Insertar(cat1);

                repositorio.Listar().ForEach(x => Console.WriteLine(x));

                //Eliminando registro
                Console.WriteLine("Seleccione el id de la categoría a eliminar");
                repositorio.Eliminar(int.Parse(Console.ReadLine()!));
                repositorio.Listar().ForEach(x => Console.WriteLine(x));

                //Actualizando registros
                Console.WriteLine("");

                repositorio.Separador();

                //***************PRODUCTOS***********
                Console.WriteLine("PRODUCTOS");
                var repoProductos = new ProductoRepositorio(contexto);

                Console.WriteLine("Inserte nombre de un producto");
                var productos = new Producto()
                {
                    Nombre = Console.ReadLine()!
                };
                Console.WriteLine($"Inserte código de categoría");

                if (int.TryParse(Console.ReadLine(), out var codigo))
                {
                    productos.CategoriaId = codigo;
                    Console.WriteLine("Inserte Precio del producto");
                    productos.Precio = float.Parse(Console.ReadLine()!);
                }
                else
                {
                    Console.WriteLine("Inserte el código correctamente");
                }
                repoProductos.Insertar(productos);

                repoProductos.Listar().ForEach(x => Console.WriteLine(x));

                //***********CLIENTES**********
                var repoClientes = new ClienteRepositorio(contexto);
                Console.WriteLine("CLIENTES");
                var clientes = new Cliente();
                Console.WriteLine("Inserte nombre de cliente");
                clientes.Nombre = Console.ReadLine()!;
                Console.WriteLine("Inserte apellidos de cliente");
                clientes.Apellidos = Console.ReadLine()!;
                Console.WriteLine("Inserte Email");
                clientes.Email = Console.ReadLine()!;

                repoClientes.Insertar(clientes);
                repoClientes.Listar().ForEach(x => Console.WriteLine(x));
                repoClientes.Separador();
                //**********VENTAS**********
                Console.WriteLine("VENTAS");
                var repoVentas = new VentaRepositorio(contexto);
                var ventas = new Venta();
                Console.WriteLine("Inserte Numero de factura");
                ventas.NumeroFactura = Console.ReadLine()!;
                Console.WriteLine("Inserte fecha venta");
                if (DateTime.TryParse(Console.ReadLine(), out var date))
                {
                    ventas.FechaVenta = date;
                    Console.WriteLine("Inserte id del cliente");
                    if (int.TryParse(Console.ReadLine(), out var val))
                    {
                        ventas.ClienteId = val;
                        Console.WriteLine("Insertar el total en ventas");
                        ventas.TotalVenta = float.Parse(Console.ReadLine()!);
                    }
                    else
                    {
                        Console.WriteLine("Colocar correctamente el id de cliente");
                    }
                }
                else
                {
                    Console.WriteLine("Insertar correctamente la fecha");
                }
                repoVentas.Insertar(ventas);
                repoVentas.Listar().ForEach(x => Console.WriteLine(x));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

    }
}
