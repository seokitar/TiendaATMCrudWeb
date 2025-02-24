using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanzador.Repositorio
{
    public interface IRepositorioBase<T>
    {
        void Eliminar(T objeto);
       
    }
}
