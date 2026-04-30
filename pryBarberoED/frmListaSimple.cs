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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        cslListaSimple cslListaSimple = new cslListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           

            {
                clsNodo n = new clsNodo();
                n.Codigo = Convert.ToInt32(txtCodigo.Text);
                n.Nombre = txtNombre.Text;
                n.Tramite = txtTramite.Text;

                cslListaSimple.Agregar(n);
                cslListaSimple.Recorrer(dgvLista);
                cslListaSimple.Recorrer(lstListaSimple);

                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
