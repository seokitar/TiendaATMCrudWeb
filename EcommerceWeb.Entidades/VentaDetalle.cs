using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EcommerceWeb.Entidades
{
    public class VentaDetalle : EntidadBase
    {

        [JsonIgnore]  // 🔥 Evita el error al serializar JSON
        public Venta? Venta { get; set; }
        public int VentaId { get; set; }
        public Producto? Producto { get; set; }
        public int ProductoId { get; set; }
        public float PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public float Total { get; set; }









    }
}
