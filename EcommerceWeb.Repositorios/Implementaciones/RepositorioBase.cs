using EcommerceWeb.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceWeb.Entidades;
using Microsoft.EntityFrameworkCore;
using ECommerceWeb.DataAccess.Data;

namespace EcommerceWeb.Repositorios.Implementaciones
{
    public class RepositorioBase<TEntidad> : IRepositorioBase<TEntidad>
        where TEntidad : EntidadBase
    {
        protected EcommerceDbContext  Context { get; set; }
        protected RepositorioBase(EcommerceDbContext context)
        {
            Context = context;
        }

        public void Separador()
        {
            Console.WriteLine(new string('*',100));
        }

        public void Actualizar(int entrada, TEntidad entidad)
        {
            var entidadExistente = buscarPorId(entrada);
            if(entidadExistente is not null)
            {
               entidadExistente=entidad;
                Context.SaveChanges();

            }
              

        }

        public TEntidad? buscarPorId(int id)
        {
            return Context.Set<TEntidad>().FirstOrDefault(x => x.Id == id);

        }

        public void Eliminar(int entrada)
        {
            var entidadExistente = buscarPorId(entrada);
            if (entidadExistente is not null)
            {
                Context.Set<TEntidad>().Remove(entidadExistente);
                Context.SaveChanges();
            }
        }

        public virtual void Insertar(TEntidad entidad)
        {
          Context.Set<TEntidad>().Add(entidad);
            Context.SaveChanges();

        }

        public List<TEntidad> Listar()
        {
            return Context.Set<TEntidad>().ToList();    
        }

        public List<TEntidad> Listar(Func<TEntidad, bool> predicado)
        {
            return Context.Set<TEntidad>()
                .Where(predicado)
                .ToList();
        }
    }
}
