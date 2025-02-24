using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanzador.Repositorio
{
    public class RepositorioBase<T>:IRepositorioBase<T>
    {

        public List<T> Lista { get; set; } =  new();

        public void Eliminar(T objeto)
        {
            if (Lista.Contains(objeto))
            {
                Lista.Remove(objeto);
            }
        }

        public virtual void Listar()
        {
            foreach (var item in Lista)
            {
                Console.WriteLine($"{item}");
            }
        }
        protected int ContarElementos()
        {
            return Lista.Count;
        }

    }

}
