using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarberoED
{
    public partial class frmColas : Form
    {
        public frmColas()
        {
            InitializeComponent();
        }

        clsCola FilaDePersoas = new clsCola();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo n = new clsNodo();
            n.Codigo = Convert.ToInt32(txtCodigo.Text);
            n.Nombre = txtNombre.Text;
            n.Tramite = txtTramite.Text;

            FilaDePersoas.Agregar(n);
            FilaDePersoas.Recorrer(dgvCola);
            FilaDePersoas.Recorrer(lstCola);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersoas.Primero != null)
            {
                FilaDePersoas.Eliminar();
                FilaDePersoas.Recorrer(dgvCola);
                FilaDePersoas.Recorrer(lstCola);
            }
            else
            {
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblTramite.Text = "";
                MessageBox.Show("No hay personas en la fila");
            }
        }




        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstCola_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmColas_Load(object sender, EventArgs e)
        {

        }
    }
}
