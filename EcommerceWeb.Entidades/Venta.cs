using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWeb.Entidades
{
    public class Venta:EntidadBase
    {
        [StringLength(20)]
        public string NumeroFactura { get; set; }
        public DateTime FechaVenta { get; set; }
        public Cliente? Cliente { get; set; }
        public int ClienteId { get; set; }
        public float TotalVenta { get; set; }
        public List<VentaDetalle> Detalles { get; set; } = new ();

        public override string ToString()
        {
            return $"{Id}: {NumeroFactura} | {FechaVenta} | {ClienteId} | {TotalVenta}";
        }

    }
}
