using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarberoED
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }
        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            clsArchivoTexto objGrabar = new clsArchivoTexto();
            objGrabar.NomArchi = "Carreras.csv";
            objGrabar.Recorrer(cmbCarrera);

            clsArchivoTexto objAlumnos = new clsArchivoTexto();
            if (File.Exists(objAlumnos.NomArchi)) objAlumnos.Recorrer(dgvAlumnos);
            btnGrabar.Enabled = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNombre.Text != "" && cmbCarrera.Text != "")
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto objRecorrer = new clsArchivoTexto();
            objRecorrer.NomArchi = "Alumnos.csv";
            objRecorrer.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
            objRecorrer.Recorrer(dgvAlumnos);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivoTexto x = new clsArchivoTexto();
            x.NomArchi = ("Alumnos.csv");
            x.BorrarTodo();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            cmbCarrera.Text = "";
        }
    }
}
