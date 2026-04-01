using GestionAdministrativaBarracas.Dominio.Personas;
using GestionAdministrativaBarracas.Dominio.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAdministrativaBarracas.Dominio.Entidades
{
    public class Egreso : Operacion
    {
        public Proveedor Proveedor { get; private set; }
        public TipoEgreso Tipo { get; private set; }

        public Egreso(
            decimal monto,
            int idEmpleado,
            Proveedor proveedor,
            TipoEgreso tipo)
            : base(monto, idEmpleado)
        {
            if (proveedor == null)
                throw new ArgumentException("El egreso debe tener un proveedor");

            Proveedor = proveedor;
            Tipo = tipo;
        }
    }
}
