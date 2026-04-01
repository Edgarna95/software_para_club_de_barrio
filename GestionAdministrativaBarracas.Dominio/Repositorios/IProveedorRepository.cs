using GestionAdministrativaBarracas.Dominio.Personas;
using System.Collections.Generic;

namespace GestionAdministrativaBarracas.Dominio.Repositories
{
    public interface IProveedorRepository
    {
        Proveedor? ObtenerPorId(int id);
        Proveedor ObtenerPorCuit(string cuit);
        IEnumerable<Proveedor> ObtenerTodos();

        void Agregar(Proveedor proveedor);
        void Actualizar(Proveedor proveedor);
        void Eliminar(int id);
    }
}
