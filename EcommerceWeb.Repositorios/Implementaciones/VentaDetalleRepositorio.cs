using EcommerceWeb.Entidades;
using ECommerceWeb.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWeb.Repositorios.Implementaciones
{
    public class VentaDetalleRepositorio : RepositorioBase<VentaDetalle>
    {
        public VentaDetalleRepositorio(EcommerceDbContext context) : base(context)
        {
        }
    }
}
