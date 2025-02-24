using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWeb.Repositorios.Interfaces
{
    //Creando las propiedades y metodos para el CRUD
    public interface IRepositorioBase<TEntidad>
    {
        //List<TEntidad> Datos { get; set; } //Sólo se usó para hacer CRUD en memoria, ahora se usa DbContext con sql server
        List<TEntidad> Listar();
        void Insertar(TEntidad entidad);
        void Eliminar(int entrada);
        void Actualizar(int entrada,TEntidad entidad);
        TEntidad? buscarPorId(int id);
        List<TEntidad> Listar(Func<TEntidad, bool> predicado);

    }
}
