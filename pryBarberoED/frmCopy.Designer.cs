namespace pryBarberoED
{
    partial class frmCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCopy));
            this.pbaboutme = new System.Windows.Forms.PictureBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbaboutme)).BeginInit();
            this.SuspendLayout();
            // 
            // pbaboutme
            // 
            this.pbaboutme.Image = ((System.Drawing.Image)(resources.GetObject("pbaboutme.Image")));
            this.pbaboutme.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbaboutme.InitialImage")));
            this.pbaboutme.Location = new System.Drawing.Point(11, 11);
            this.pbaboutme.Margin = new System.Windows.Forms.Padding(2);
            this.pbaboutme.Name = "pbaboutme";
            this.pbaboutme.Size = new System.Drawing.Size(260, 231);
            this.pbaboutme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbaboutme.TabIndex = 4;
            this.pbaboutme.TabStop = false;
            // 
            // lblDatos
            // 
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(50, 262);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(221, 130);
            this.lblDatos.TabIndex = 9;
            this.lblDatos.Text = "NOMBRE: Bautista Barbero\r\nDNI: 47666302\r\nCARRERA: Analista en Sistemas de Computa" +
    "ción\r\nMATERIA: Estructura de Datos\r\nPROFESORA: Érica Bongiovanni";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 262);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "© ";
            // 
            // frmCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(287, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.pbaboutme);
            this.Name = "frmCopy";
            this.Text = "frmCopy";
            ((System.ComponentModel.ISupportInitialize)(this.pbaboutme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbaboutme;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label label1;
    }
}