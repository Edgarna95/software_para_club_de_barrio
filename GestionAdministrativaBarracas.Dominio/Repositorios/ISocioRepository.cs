using GestionAdministrativaBarracas.Dominio.Personas;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAdministrativaBarracas.Dominio.Repositorios
{
    public interface ISocioRepository
    {
        void Agregar(Socio socio);
        Socio ObtenerPorDni(string dni);
        IEnumerable<Socio> ObtenerTodos();
    }
}