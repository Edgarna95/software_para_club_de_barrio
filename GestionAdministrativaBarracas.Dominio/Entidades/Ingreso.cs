using GestionAdministrativaBarracas.Dominio.Entidades.Enums;
using GestionAdministrativaBarracas.Dominio.Personas;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAdministrativaBarracas.Dominio.Entidades
{
    public class Ingreso : Operacion
    {
        public Socio Socio { get; private set; }
        public TipoIngreso Tipo { get; private set; }

        public Ingreso(
            decimal monto,
            int idEmpleado,
            TipoIngreso tipo,
            Socio socio = null)
            : base(monto, idEmpleado)
        {
            if (tipo == TipoIngreso.Cuota)
            {
                if (socio == null)
                    throw new ArgumentException("La cuota debe estar asociada a un socio");

                if (!socio.Activo)
                    throw new ArgumentException("El socio está inactivo y no puede pagar cuota");
            }

            Tipo = tipo;
            Socio = socio;
        }
    }
}


