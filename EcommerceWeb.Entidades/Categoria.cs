using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWeb.Entidades
{
    public class Categoria : EntidadBase
    {
        [StringLength(100)]
        public string? Nombre { get; set; }
        [StringLength(100)]
        public string? Descripcion { get; set; }

        public override string ToString()
        {
            return $"{Id} ==> {Nombre} | {Descripcion}";
        }

    }
}
