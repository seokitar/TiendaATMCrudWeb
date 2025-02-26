using EcommerceWeb.Entidades;
using EcommerceWeb.Repositorios.Interfaces;
using ECommerceWeb.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWeb.Repositorios.Implementaciones
{
    public class VentaDetalleRepositorio : RepositorioBase<VentaDetalle>,IVentaDetalleRepositorio
    {
        public VentaDetalleRepositorio(EcommerceDbContext context) : base(context)
        {
        }
    }
}
