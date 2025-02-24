using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Modelos
{
    internal class Superheroe
    {
        public string? Nombre { get; set; }
        public string? Poder { get; set; }

        public override string ToString()
        {
            return $"El superheroe {Nombre} tiene el poder {Poder}";
        }
    }
}
