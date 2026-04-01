using GestionAdministrativaBarracas.Dominio.Personas;
using GestionAdministrativaBarracas.Dominio.Repositories;
using GestionAdministrativaBarracas.Infrastructure.Repositories;
using System;
using System.Windows.Forms;

namespace GestionAdministrativaBarracas.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString =
    System.Configuration.ConfigurationManager
        .ConnectionStrings["DefaultConnection"]
        .ConnectionString;

            IProveedorRepository repo =
                new ProveedorRepositorySqlServer(connectionString);


            
            
            Application.Run(new FormListadoProveedores(repo));
        }
    }
}
