using Entidades;

namespace Lanzador.Repositorio
{
    //Clase derivada para Producto
    public class RepositorioProductos : RepositorioBase<Producto>
    {
        public override void Listar()
        {
            foreach (var item in Lista)
            {
                Console.WriteLine($"El código del producto es {item.CodPro} y el nombre es {item.Nombre}");
            }
            Console.WriteLine($"Existen {ContarElementos()} elementos");
        }

       

    }

}
