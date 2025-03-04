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
    public class ProductoRepositorio : RepositorioBase<Producto>,IProductoRepositorio
    {
        public ProductoRepositorio(EcommerceDbContext context) : base(context)
        {
            
        }
        public Producto? MostrarProductoCategoria(int IdProducto)
        {
            return Context.Set<Producto>()
                .Include(x => x.Categoria)
                .FirstOrDefault(x => x.Id == IdProducto);



        }
    }
}
