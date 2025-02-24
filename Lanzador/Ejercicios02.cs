using Entidades;
using Lanzador.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanzador
{
    public class Ejercicios02
    {
        //Aplicando RepositorioBase
        public static void Ejecutar()
        {
            var repositorio = new RepositorioProductos();
            repositorio.Lista.Add(new()
            {
                CodPro = 001,
                Nombre = "Samsung S24 ULTRA"
            });

            var producto = new Producto()
            {
                CodPro = 002,
                Nombre = "Powebank 2005"
            };
            repositorio.Lista.Add(producto);
            repositorio.Listar();
            Console.WriteLine("\n");
            Console.WriteLine(new string('*',100));
            Console.WriteLine("Comprobamos la eliminación");
            repositorio.Eliminar(producto);
            repositorio.Listar();











        }

    }
}
