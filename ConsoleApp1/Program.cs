// See https://aka.ms/new-console-template for more information
using Calculadora;
using System.Net.Http.Headers;
using System.Timers;

Detalles obj1 = new Detalles();

Console.WriteLine("Bienvenido a la calculadora de Oscar");
Console.WriteLine("Elige una operación a realizar:\n(1)Sumar\n(2)Restar\n(3)Dividir\n(4)Multiplicar");
var resultado = int.TryParse(Console.ReadLine(), out int option);
Console.WriteLine("Inserte primer número");
var Num1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Inserte segundo numero");
var Num2 = double.Parse(Console.ReadLine()!);
double resultadoOperacion = 0.0;


if (resultado)
{
    switch (option)
    {
        case 1:
            resultadoOperacion = obj1.Sumar(Num1,Num2);
            Console.WriteLine($"El resultado es:{resultadoOperacion}");
            break;
           
        case 2:
            resultadoOperacion = obj1.Restar(Num1,Num2);
            Console.WriteLine($"El resultado es:{resultadoOperacion}");
            break;
        case 3:
            resultadoOperacion = obj1.Dividir(Num1,Num2);
            Console.WriteLine($"El resultado es:{resultadoOperacion}");
            break;
        case 4:
            resultadoOperacion = obj1.Multiplicar(Num1,Num2);
            Console.WriteLine($"El resultado es:{resultadoOperacion}");
            break;
       
       

    }
    obj1.fin();

}
else
{
    Console.WriteLine("Ingrese una opción correcta por favor, elija algún número");
}