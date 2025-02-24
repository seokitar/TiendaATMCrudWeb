// See https://aka.ms/new-console-template for more information
using EstructurasRepetitivas;
using System.Reflection.Metadata;
#if DEBUG
Console.ForegroundColor = ConsoleColor.Red;
#else
Console.ForegroundColor = ConsoleColor.Green; 

#endif
Console.WriteLine("Hello, World!");

Prueba persona = new Prueba();
Prueba persona2 = new Prueba();
//Insertando datos de alumno
Console.WriteLine("Inserte su nombre por favor");
persona.nombre = Console.ReadLine();
Console.WriteLine("Inserte su edad");
persona.edad=int.Parse(Console.ReadLine()!);
Console.WriteLine("Inserte su nombre por favor");
persona2.nombre = Console.ReadLine();
Console.WriteLine("Inserte su edad");
persona2.edad=int.Parse(Console.ReadLine()!);


Console.WriteLine($"Tus datos completos de alumno son:{persona}");
Console.WriteLine($"Tus datos completos de alumno son:{persona2}");