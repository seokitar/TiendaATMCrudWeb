using EcommerceWeb.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWeb.Repositorios.Interfaces
{
    public interface IProductoRepositorio:IRepositorioBase<Producto>
    {
        Producto? MostrarProductoCategoria(int id);
    }
}
