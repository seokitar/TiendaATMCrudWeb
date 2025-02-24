using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Detalles
    {

        public double Sumar(double x, double y)
        {
            return x + y;

        }

        public double Multiplicar(double x, double y)
        {
            return x * y;
        }


        public double Dividir(double x, double y)
        {
            return x / y;
        }


        public double Restar(double x, double y)
        {
            return x - y;
        }
        public void fin()
        {
            Console.WriteLine("Gracias por usar esta calculadora");
        }
    }
}
