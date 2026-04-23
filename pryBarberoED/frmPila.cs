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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        private void frmPila_Load(object sender, EventArgs e)
        {

        }
        clsPila Pila = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo nuevo = new clsNodo();
            nuevo.Codigo = Convert.ToInt32(lblCodRdo.Text);
            nuevo.Nombre = lblNomRdo.Text;
            nuevo.Tramite = lblTramiteRdo.Text;

            Pila.Agregar(nuevo);
            Pila.Recorrer(dgvPila); //coloco el nombre en la grilla
            Pila.Recorrer(lstPila); //coloco el nombre de la lista 
            Pila.Recorrer("ArchivoPila.csv");

            lblCodRdo.Text = "";
            lblNomRdo.Text = "";
            lblTramiteRdo.Text = "";
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Pila.Primero != null)
            {
                lblCodRdo.Text = Pila.Primero.Codigo.ToString();
                lblNomRdo.Text = Pila.Primero.Nombre;
                lblTramiteRdo.Text = Pila.Primero.Tramite;

                Pila.Eliminar();
                Pila.Recorrer(dgvPila);
                Pila.Recorrer(lstPila);
            }
            else
            {
                lblCodRdo.Text = "";
                lblNomRdo.Text = "";
                lblTramiteRdo.Text = "";
            }
        }
    }
}
