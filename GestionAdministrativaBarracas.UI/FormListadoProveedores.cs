using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAdministrativaBarracas.Dominio.Repositories;
using Microsoft.Data.SqlClient;


namespace GestionAdministrativaBarracas.UI
{
    public partial class FormListadoProveedores : Form
    {
        private readonly IProveedorRepository _repo;

        public FormListadoProveedores(IProveedorRepository repo)
        {
            InitializeComponent();
            _repo = repo;

        }



        private void FormListadoProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = _repo.ObtenerTodos()
                                             .Select(p => new
                                             {
                                                 p.Nombre,
                                                 p.Cuit
                                             })
                                             .ToList();
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var form = new FormProveedor(_repo))
            {
                form.ShowDialog();
            }

            CargarProveedores();
        }


    }
}

