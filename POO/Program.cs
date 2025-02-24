// See https://aka.ms/new-console-template for more information
using POO;

Console.WriteLine("Bienvenido al aprendizaje de POO de Osquitar!");
Console.WriteLine("Ingrese el programa a ejecutar");

Console.WriteLine("Escoge una opción:");
Console.WriteLine("1. Arrays");
Console.WriteLine("2. herencia");

bool valor = int.TryParse(Console.ReadLine(), out int option);
if (!valor)
    Console.WriteLine("Inserte la opción correcta por favor");
else
    switch (option)
    {
        case 1:
            Arrays.Ejecutar();
            break;
        default:
            Console.WriteLine("No elegiste una opción disponible");
            break;
    }