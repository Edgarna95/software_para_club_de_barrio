using GestionAdministrativaBarracas.Dominio.Entidades;
using GestionAdministrativaBarracas.Dominio.Entidades.Enums;
using GestionAdministrativaBarracas.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAdministrativaBarracas.Tests
{
    public class OperacionRepositoryTests
    {
        [Test]
        public void Agregar_Deberia_Guardar_Operacion()
        {
            var repo = new OperacionRepositoryInMemory();

            var ingreso = new Ingreso(
                monto: 1000m,
                idEmpleado: 1,
                tipo: TipoIngreso.Donacion
            );

            repo.Agregar(ingreso);
            var resultado = repo.ObtenerTodas().FirstOrDefault();

            Assert.IsNotNull(resultado);
            Assert.AreEqual(1000m, resultado.Monto);
        }

        [Test]
        public void Agregar_VariasOperaciones_Deberia_Devolver_Todas()
        {
            var repo = new OperacionRepositoryInMemory();

            var ingreso1 = new Ingreso(1000m, 1, TipoIngreso.Donacion);
            var ingreso2 = new Ingreso(2000m, 2, TipoIngreso.Donacion);

            repo.Agregar(ingreso1);
            repo.Agregar(ingreso2);

            var operaciones = repo.ObtenerTodas().ToList();

            Assert.AreEqual(2, operaciones.Count);
            Assert.AreEqual(1000m, operaciones[0].Monto);
            Assert.AreEqual(2000m, operaciones[1].Monto);
        }
    }
}
