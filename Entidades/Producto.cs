using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int CodPro { get; set; }
        public string? Nombre { get; set; }

        public Producto(int cod, string nombre)
        {
            CodPro = cod; 
            Nombre = nombre;    
        }

        public Producto()
        {
        }

        public override string ToString()
        {
            return $"{CodPro}|{Nombre}";
        }

    }
}
