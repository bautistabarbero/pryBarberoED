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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }

         
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            {
                clsNodo n = new clsNodo();
                n.Codigo = Convert.ToInt32(txtCodigo.Text);
                n.Nombre = txtNombre.Text;
                n.Tramite = txtTramite.Text;

                cslListaDoble.Agregar(n);
                cslListaDoble.Recorrer(dgvListaDoble);
                cslListaDoble.Recorrer(lstListaDoble);

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
        }
    }
}
