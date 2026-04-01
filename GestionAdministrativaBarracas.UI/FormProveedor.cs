using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionAdministrativaBarracas.Dominio.Personas;
using GestionAdministrativaBarracas.Dominio.Repositories;

namespace GestionAdministrativaBarracas.UI
{
    public partial class FormProveedor : Form
    {
        private readonly IProveedorRepository _repo;
        public FormProveedor(IProveedorRepository repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var proveedor = new Proveedor(
                    tbNombre.Text,
                    tbCUIT.Text
                );

                _repo.Agregar(proveedor);

                MessageBox.Show("Proveedor agregado correctamente");

                tbNombre.Clear();
                tbCUIT.Clear();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       
    }
}
