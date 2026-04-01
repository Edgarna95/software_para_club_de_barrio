using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using GestionAdministrativaBarracas.Dominio.Personas;
using GestionAdministrativaBarracas.Dominio.Repositories;

namespace GestionAdministrativaBarracas.Infrastructure.Repositories
{
    public class ProveedorRepositorySqlServer : IProveedorRepository
    {
        private readonly string _connectionString;

        public ProveedorRepositorySqlServer(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Agregar(Proveedor proveedor)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand(
                    @"INSERT INTO Proveedores (Nombre, Cuit)
                      VALUES (@nombre, @cuit)", connection);

                command.Parameters.AddWithValue("@nombre", proveedor.Nombre);
                command.Parameters.AddWithValue("@cuit", proveedor.Cuit);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw new ArgumentException(
                        "Ya existe un proveedor registrado con el CUIT ingresado");
                }
            }
        }

        public IEnumerable<Proveedor> ObtenerTodos()
        {
            var lista = new List<Proveedor>();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand(
                    "SELECT Nombre, Cuit FROM Proveedores", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Proveedor(
                            reader.GetString(0),
                            reader.GetString(1)
                        ));
                    }
                }
            }

            return lista;
        }

        public Proveedor ObtenerPorCuit(string cuit)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand(
                    "SELECT Nombre, Cuit FROM Proveedores WHERE Cuit = @cuit",
                    connection);

                command.Parameters.AddWithValue("@cuit", cuit);

                using (var reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;

                    return new Proveedor(
                        reader.GetString(0),
                        reader.GetString(1)
                    );
                }
            }
        }

        public void Actualizar(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Proveedor ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
