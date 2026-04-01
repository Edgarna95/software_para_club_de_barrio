using GestionAdministrativaBarracas.Dominio.Entidades;
using GestionAdministrativaBarracas.Dominio.Repositories;
using GestionAdministrativaBarracas.Dominio.Repositorios;
using System.Collections.Generic;

namespace GestionAdministrativaBarracas.Infrastructure.Repositories
{
    public class OperacionRepositoryInMemory : IOperacionRepository
    {
        private readonly List<Operacion> _operaciones = new List<Operacion>();

        public void Agregar(Operacion operacion)
        {
            _operaciones.Add(operacion);
        }

        public IEnumerable<Operacion> ObtenerTodas()
        {
            return _operaciones;
        }
    }
}
