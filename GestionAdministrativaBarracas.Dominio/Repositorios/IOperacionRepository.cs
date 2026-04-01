using System.Collections.Generic;
using GestionAdministrativaBarracas.Dominio.Entidades;

namespace GestionAdministrativaBarracas.Dominio.Repositories
{
    public interface IOperacionRepository
    {
        void Agregar(Operacion operacion);
        IEnumerable<Operacion> ObtenerTodas();
    }
}
