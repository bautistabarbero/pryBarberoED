namespace pryBarberoED
{
    partial class frmPila
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
            this.gbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lblTramiteRdo = new System.Windows.Forms.Label();
            this.lblNomRdo = new System.Windows.Forms.Label();
            this.lblCodRdo = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblTramit = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNomb = new System.Windows.Forms.Label();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbColas = new System.Windows.Forms.PictureBox();
            this.gbElementoEliminado.SuspendLayout();
            this.gbNuevoElemento.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbElementoEliminado
            // 
            this.gbElementoEliminado.Controls.Add(this.lblTramiteRdo);
            this.gbElementoEliminado.Controls.Add(this.lblNomRdo);
            this.gbElementoEliminado.Controls.Add(this.lblCodRdo);
            this.gbElementoEliminado.Controls.Add(this.lblCod);
            this.gbElementoEliminado.Controls.Add(this.lblTramit);
            this.gbElementoEliminado.Controls.Add(this.btnEliminar);
            this.gbElementoEliminado.Controls.Add(this.lblNomb);
            this.gbElementoEliminado.Location = new System.Drawing.Point(370, 12);
            this.gbElementoEliminado.Name = "gbElementoEliminado";
            this.gbElementoEliminado.Size = new System.Drawing.Size(169, 164);
            this.gbElementoEliminado.TabIndex = 27;
            this.gbElementoEliminado.TabStop = false;
            this.gbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // lblTramiteRdo
            // 
            this.lblTramiteRdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteRdo.Location = new System.Drawing.Point(67, 90);
            this.lblTramiteRdo.Name = "lblTramiteRdo";
            this.lblTramiteRdo.Size = new System.Drawing.Size(85, 20);
            this.lblTramiteRdo.TabIndex = 21;
            // 
            // lblNomRdo
            // 
            this.lblNomRdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomRdo.Location = new System.Drawing.Point(67, 61);
            this.lblNomRdo.Name = "lblNomRdo";
            this.lblNomRdo.Size = new System.Drawing.Size(85, 20);
            this.lblNomRdo.TabIndex = 20;
            // 
            // lblCodRdo
            // 
            this.lblCodRdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodRdo.Location = new System.Drawing.Point(90, 34);
            this.lblCodRdo.Name = "lblCodRdo";
            this.lblCodRdo.Size = new System.Drawing.Size(62, 20);
            this.lblCodRdo.TabIndex = 19;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(18, 35);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(43, 13);
            this.lblCod.TabIndex = 9;
            this.lblCod.Text = "Código:";
            // 
            // lblTramit
            // 
            this.lblTramit.AutoSize = true;
            this.lblTramit.Location = new System.Drawing.Point(18, 91);
            this.lblTramit.Name = "lblTramit";
            this.lblTramit.Size = new System.Drawing.Size(45, 13);
            this.lblTramit.TabIndex = 17;
            this.lblTramit.Text = "Trámite:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(21, 124);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 34);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblNomb
            // 
            this.lblNomb.AutoSize = true;
            this.lblNomb.Location = new System.Drawing.Point(18, 61);
            this.lblNomb.Name = "lblNomb";
            this.lblNomb.Size = new System.Drawing.Size(47, 13);
            this.lblNomb.TabIndex = 15;
            this.lblNomb.Text = "Nombre:";
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
            this.gbNuevoElemento.Location = new System.Drawing.Point(195, 12);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Size = new System.Drawing.Size(169, 164);
            this.gbNuevoElemento.TabIndex = 26;
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
            this.gbListado.Controls.Add(this.lstPila);
            this.gbListado.Controls.Add(this.dgvPila);
            this.gbListado.Location = new System.Drawing.Point(6, 182);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(533, 204);
            this.gbListado.TabIndex = 25;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(16, 19);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(157, 160);
            this.lstPila.TabIndex = 12;
            // 
            // dgvPila
            // 
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colDeuda});
            this.dgvPila.Location = new System.Drawing.Point(179, 19);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.RowHeadersVisible = false;
            this.dgvPila.RowHeadersWidth = 51;
            this.dgvPila.Size = new System.Drawing.Size(313, 158);
            this.dgvPila.TabIndex = 8;
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
            // pbColas
            // 
            this.pbColas.Image = global::pryBarberoED.Properties.Resources._1AD878F9_AF2E_400F_98DB_80CD7438AC93_;
            this.pbColas.Location = new System.Drawing.Point(6, 7);
            this.pbColas.Name = "pbColas";
            this.pbColas.Size = new System.Drawing.Size(183, 169);
            this.pbColas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbColas.TabIndex = 24;
            this.pbColas.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 396);
            this.Controls.Add(this.gbElementoEliminado);
            this.Controls.Add(this.gbNuevoElemento);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.pbColas);
            this.Name = "frmPila";
            this.Text = "frmPila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            this.gbElementoEliminado.ResumeLayout(false);
            this.gbElementoEliminado.PerformLayout();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbElementoEliminado;
        private System.Windows.Forms.Label lblTramiteRdo;
        private System.Windows.Forms.Label lblNomRdo;
        private System.Windows.Forms.Label lblCodRdo;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblTramit;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNomb;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.PictureBox pbColas;
    }
}