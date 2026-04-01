using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAdministrativaBarracas.Dominio.Personas
{
    public class Socio
    {
        public int Id { get; private set; }
        public string NombreCompleto { get; private set; }
        public string Dni { get; private set; }
        public DateTime FechaAlta { get; private set; }
        public bool Activo { get; private set; }

        public Socio(string nombreCompleto, string dni)
        {
            if (string.IsNullOrWhiteSpace(nombreCompleto))
                throw new ArgumentException("El nombre del socio es obligatorio");

            if (string.IsNullOrWhiteSpace(dni))
                throw new ArgumentException("El DNI del socio es obligatorio");

            NombreCompleto = nombreCompleto;
            Dni = dni;
            FechaAlta = DateTime.Today;
            Activo = true;
        }

        public void DarDeBaja()
        {
            Activo = false;
        }
    }

}
