namespace pryBarberoED
{
    partial class frmListaDoble
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbElementoaEliminar = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lstListaDoble = new System.Windows.Forms.ListBox();
            this.dgvListaDoble = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpListarDatos = new System.Windows.Forms.GroupBox();
            this.optDescendete = new System.Windows.Forms.RadioButton();
            this.optAscendente = new System.Windows.Forms.RadioButton();
            this.pbColas = new System.Windows.Forms.PictureBox();
            this.gbElementoaEliminar.SuspendLayout();
            this.gbNuevoElemento.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).BeginInit();
            this.grpListarDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbElementoaEliminar
            // 
            this.gbElementoaEliminar.Controls.Add(this.cmbCodigo);
            this.gbElementoaEliminar.Controls.Add(this.lblCod);
            this.gbElementoaEliminar.Controls.Add(this.btnEliminar);
            this.gbElementoaEliminar.Location = new System.Drawing.Point(376, 17);
            this.gbElementoaEliminar.Name = "gbElementoaEliminar";
            this.gbElementoaEliminar.Size = new System.Drawing.Size(169, 93);
            this.gbElementoaEliminar.TabIndex = 35;
            this.gbElementoaEliminar.TabStop = false;
            this.gbElementoaEliminar.Text = "Elemento a Eliminar";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(64, 19);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(97, 21);
            this.cmbCodigo.TabIndex = 12;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(6, 22);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 9;
            this.lblCod.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 50);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(152, 34);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // gbNuevoElemento
            // 
            this.gbNuevoElemento.Controls.Add(this.txtTramite);
            this.gbNuevoElemento.Controls.Add(this.lblCodigo);
            this.gbNuevoElemento.Controls.Add(this.lblTramite);
            this.gbNuevoElemento.Controls.Add(this.txtCodigo);
            this.gbNuevoElemento.Controls.Add(this.txtNombre);
            this.gbNuevoElemento.Controls.Add(this.btnAgregar);
            this.gbNuevoElemento.Controls.Add(this.lblNombre);
            this.gbNuevoElemento.Location = new System.Drawing.Point(201, 17);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Size = new System.Drawing.Size(169, 164);
            this.gbNuevoElemento.TabIndex = 34;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(67, 91);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(85, 20);
            this.txtTramite.TabIndex = 18;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Código:";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(18, 91);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 17;
            this.lblTramite.Text = "Tramite:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(90, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(62, 20);
            this.txtCodigo.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(67, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(85, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 117);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 34);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre:";
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.lstListaDoble);
            this.gbListado.Controls.Add(this.dgvListaDoble);
            this.gbListado.Location = new System.Drawing.Point(12, 187);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(533, 204);
            this.gbListado.TabIndex = 33;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lstListaDoble
            // 
            this.lstListaDoble.FormattingEnabled = true;
            this.lstListaDoble.Location = new System.Drawing.Point(16, 19);
            this.lstListaDoble.Name = "lstListaDoble";
            this.lstListaDoble.Size = new System.Drawing.Size(157, 160);
            this.lstListaDoble.TabIndex = 12;
            // 
            // dgvListaDoble
            // 
            this.dgvListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colDeuda});
            this.dgvListaDoble.Location = new System.Drawing.Point(179, 19);
            this.dgvListaDoble.Name = "dgvListaDoble";
            this.dgvListaDoble.RowHeadersVisible = false;
            this.dgvListaDoble.RowHeadersWidth = 51;
            this.dgvListaDoble.Size = new System.Drawing.Size(313, 158);
            this.dgvListaDoble.TabIndex = 8;
            // 
            // colCodigo
            // 
            this.colCodigo.Frozen = true;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 60;
            // 
            // colNombre
            // 
            this.colNombre.Frozen = true;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 125;
            // 
            // colDeuda
            // 
            this.colDeuda.Frozen = true;
            this.colDeuda.HeaderText = "Trámite";
            this.colDeuda.MinimumWidth = 6;
            this.colDeuda.Name = "colDeuda";
            this.colDeuda.Width = 125;
            // 
            // grpListarDatos
            // 
            this.grpListarDatos.Controls.Add(this.optDescendete);
            this.grpListarDatos.Controls.Add(this.optAscendente);
            this.grpListarDatos.Location = new System.Drawing.Point(376, 116);
            this.grpListarDatos.Name = "grpListarDatos";
            this.grpListarDatos.Size = new System.Drawing.Size(169, 61);
            this.grpListarDatos.TabIndex = 36;
            this.grpListarDatos.TabStop = false;
            this.grpListarDatos.Text = "Listar Datos";
            // 
            // optDescendete
            // 
            this.optDescendete.AutoSize = true;
            this.optDescendete.Location = new System.Drawing.Point(9, 38);
            this.optDescendete.Name = "optDescendete";
            this.optDescendete.Size = new System.Drawing.Size(89, 17);
            this.optDescendete.TabIndex = 1;
            this.optDescendete.TabStop = true;
            this.optDescendete.Text = "Descendente";
            this.optDescendete.UseVisualStyleBackColor = true;
            // 
            // optAscendente
            // 
            this.optAscendente.AutoSize = true;
            this.optAscendente.Location = new System.Drawing.Point(9, 19);
            this.optAscendente.Name = "optAscendente";
            this.optAscendente.Size = new System.Drawing.Size(82, 17);
            this.optAscendente.TabIndex = 0;
            this.optAscendente.TabStop = true;
            this.optAscendente.Text = "Ascendente";
            this.optAscendente.UseVisualStyleBackColor = true;
            // 
            // pbColas
            // 
            this.pbColas.Image = global::pryBarberoED.Properties.Resources._0372131b_1ff8_49ce_b14f_2f9a5627c4d4;
            this.pbColas.Location = new System.Drawing.Point(12, 12);
            this.pbColas.Name = "pbColas";
            this.pbColas.Size = new System.Drawing.Size(183, 169);
            this.pbColas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbColas.TabIndex = 32;
            this.pbColas.TabStop = false;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 415);
            this.Controls.Add(this.grpListarDatos);
            this.Controls.Add(this.gbElementoaEliminar);
            this.Controls.Add(this.gbNuevoElemento);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.pbColas);
            this.Name = "frmListaDoble";
            this.Text = "frmListaDoble";
            this.Load += new System.EventHandler(this.frmListaDoble_Load);
            this.gbElementoaEliminar.ResumeLayout(false);
            this.gbElementoaEliminar.PerformLayout();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).EndInit();
            this.grpListarDatos.ResumeLayout(false);
            this.grpListarDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbElementoaEliminar;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.ListBox lstListaDoble;
        private System.Windows.Forms.DataGridView dgvListaDoble;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.PictureBox pbColas;
        private System.Windows.Forms.GroupBox grpListarDatos;
        private System.Windows.Forms.RadioButton optDescendete;
        private System.Windows.Forms.RadioButton optAscendente;
    }
}