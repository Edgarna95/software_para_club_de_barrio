using GestionAdministrativaBarracas.Dominio.Personas;
using GestionAdministrativaBarracas.Dominio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionAdministrativaBarracas.Infrastructure.Repositories
{
    public class ProveedorRepositoryInMemory : IProveedorRepository
    {
        private readonly List<Proveedor> _proveedores = new List<Proveedor>();

        public void Actualizar(Proveedor proveedor)
        {
            throw new System.NotImplementedException();
        }

        public void Agregar(Proveedor proveedor)
        {
            var cuitNormalizado = NormalizarCuit(proveedor.Cuit);

            if (_proveedores.Any(p =>
                NormalizarCuit(p.Cuit) == cuitNormalizado))
            {
                throw new ArgumentException("Ya existe un proveedor registrado con el CUIT ingresado");
            }

            _proveedores.Add(proveedor);
        }

        public void Eliminar(int id)
        {
            throw new System.NotImplementedException();
        }

        public Proveedor ObtenerPorCuit(string cuit)
        {
            return _proveedores.FirstOrDefault(p => p.Cuit == cuit);
        }

        public Proveedor ObtenerPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Proveedor> ObtenerTodos()
        {
            return _proveedores;
        }

        private string NormalizarCuit(string cuit)
        {
            return cuit.Replace("-", "").Trim();
        }
    }
}
