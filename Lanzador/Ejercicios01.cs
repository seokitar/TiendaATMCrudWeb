using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanzador
{
    public class Ejercicios01
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Aplicando LIST<> con objetos clase\n");
            //Categorias
            Console.WriteLine("Inserte código de categoría");
            int Cod = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Inserte nombre de categoría");
            string Nom = Console.ReadLine()!;

            Console.WriteLine(new string('*', 100));

            //Productos
            Console.WriteLine("Inserte código de Producto");
            int codPro = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Inserte nombre de Producto");
            string nomPro = Console.ReadLine()!;

            var cat1 = new List<Categoria>();
            cat1.Add(new() { CodCat = Cod, NomCat = Nom });

            var pro1 = new List<Producto>();
            pro1.Add(new() { CodPro = codPro, Nombre = nomPro });

            foreach (var cat in cat1)
            {
                Console.WriteLine(cat);
            }

            foreach (var pro in pro1)
            {
                Console.WriteLine(pro);
            }

        }
    }
}
