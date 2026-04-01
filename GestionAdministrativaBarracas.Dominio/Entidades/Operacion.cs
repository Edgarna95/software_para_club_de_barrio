using GestionAdministrativaBarracas.Dominio.Repositories;
using GestionAdministrativaBarracas.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAdministrativaBarracas.Dominio.Entidades
{
    public abstract class Operacion : IOperacionRepository
    {
        public DateTime Fecha { get; private set; }
        public decimal Monto { get; private set; }
        public int IdEmpleado { get; private set; }

        protected Operacion(decimal monto, int idEmpleado)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a cero");

            Fecha = DateTime.Now;
            Monto = monto;
            IdEmpleado = idEmpleado;
        }

        public void Agregar(Operacion operacion)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Operacion> ObtenerTodas()
        {
            throw new NotImplementedException();
        }
    }

}
