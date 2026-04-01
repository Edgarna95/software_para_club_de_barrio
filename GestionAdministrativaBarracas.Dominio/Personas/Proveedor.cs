using System;
using System.Collections.Generic;
using System.Text;

namespace GestionAdministrativaBarracas.Dominio.Personas
{
    public class Proveedor
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Cuit { get; private set; }

        public Proveedor(string nombre, string cuit)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio");

            if (string.IsNullOrWhiteSpace(cuit))
                throw new ArgumentException("El CUIT es obligatorio");

            Nombre = nombre;
            Cuit = cuit;
        }
    }
}
