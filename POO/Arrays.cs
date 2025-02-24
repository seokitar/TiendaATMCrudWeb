using POO.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Arrays
    {

        public static void Separador()
        {
            string separa = new string('*', 100);
            Console.WriteLine(separa);
        }
        public static void Ejecutar()
        {
            Console.WriteLine("Hola saludos mascota");
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] letras = new string[5] { "juan", "pedro", "martina", "pepe", "mariano" };

            List<int> list = new List<int>();
            Console.WriteLine($"Hay {letras.Length} nombres en este arreglo");
            foreach (var item in letras)
            {

                Console.WriteLine($"{item} y tiene {item.Length} letras y son:");

                foreach (var item2 in item)
                {
                    Console.WriteLine($"{item2}");
                }
            }

            Separador();

            Console.WriteLine("Trabajando con colecciones fuertemente no tipados - ARRAYLIST");

            ArrayList list2 = new ArrayList();
            list2.Add(1);
            list2.Add("Oscar Mendoza");
            list2.Add(45.5f);
            list2.Add(45.5d);
            list2.Add(true);
            list2.Add(2024 - 08 - 04);
            list2[3] = 600d;

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            Separador();

            Console.WriteLine("Trabajando con colecciones fuertemente tipados (objetos) LIST<>");

            var superheroes = new List<Superheroe>();
            superheroes.Add(new Superheroe()
            {
                Nombre = "Spiderman",
                Poder = "Volar"
            });
            superheroes.Add(new Superheroe()
            {
                Nombre = "Hulk",
                Poder = "Golpear"
            });

         

            foreach (var item2 in superheroes)
            {
                Console.WriteLine(item2);
            }
        }




    }
}
