using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWeb.Entidades
{
    public class Producto:EntidadBase
    {
        public string Nombre { get; set; } = default!;
        public float Precio  { get; set; }
        public Categoria? Categoria { get; set; }
        public int CategoriaId { get; set; }    



        public override string ToString()
        {
            return $"{Id} : {Nombre} | $ {Precio:N2}";
        }

    }
}
