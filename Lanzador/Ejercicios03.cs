using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanzador
{
    public class Ejercicios03
    {
       public static void Ejecutar()
        {
            Func<int, int> multiplicacion = (x) => x * x;
            Console.WriteLine(multiplicacion(5));

            var list = new List<int>() {1,2,3,4,5,6};
            var coleccion= list.Where(x => x<4).ToList();
         
           


            coleccion.ForEach(x => Console.WriteLine(x));
        }




    }
}
