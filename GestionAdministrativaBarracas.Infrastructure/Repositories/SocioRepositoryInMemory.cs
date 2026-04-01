using GestionAdministrativaBarracas.Dominio.Personas;
using GestionAdministrativaBarracas.Dominio.Repositories;
using GestionAdministrativaBarracas.Dominio.Repositorios;
using System.Collections.Generic;
using System.Linq;


namespace GestionAdministrativaBarracas.Infrastructure.Repositories
{
    public class SocioRepositoryInMemory : ISocioRepository
    {
        private readonly List<Socio> _socios = new List<Socio>();

        public void Agregar(Socio socio)
        {
            _socios.Add(socio);
        }

        public Socio ObtenerPorDni(string dni)
        {
            return _socios.FirstOrDefault(s => s.Dni == dni);
        }

        public IEnumerable<Socio> ObtenerTodos()
        {
            return _socios;
        }
    }
}