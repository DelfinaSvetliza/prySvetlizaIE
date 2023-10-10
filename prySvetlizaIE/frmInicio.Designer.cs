namespace prySvetlizaIE
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.pctSeguro = new System.Windows.Forms.PictureBox();
            this.tmrReloj = new System.Windows.Forms.Timer(this.components);
            this.prgBarraProgreso = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pctSeguro)).BeginInit();
            this.SuspendLayout();
            // 
            // pctSeguro
            // 
            this.pctSeguro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctSeguro.Image = global::prySvetlizaIE.Properties.Resources.logo_logica;
            this.pctSeguro.Location = new System.Drawing.Point(0, 0);
            this.pctSeguro.Name = "pctSeguro";
            this.pctSeguro.Size = new System.Drawing.Size(560, 344);
            this.pctSeguro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSeguro.TabIndex = 0;
            this.pctSeguro.TabStop = false;
            this.pctSeguro.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tmrReloj
            // 
            this.tmrReloj.Enabled = true;
            this.tmrReloj.Tick += new System.EventHandler(this.tmrReloj_Tick);
            // 
            // prgBarraProgreso
            // 
            this.prgBarraProgreso.Location = new System.Drawing.Point(111, 302);
            this.prgBarraProgreso.Name = "prgBarraProgreso";
            this.prgBarraProgreso.Size = new System.Drawing.Size(339, 23);
            this.prgBarraProgreso.TabIndex = 1;
            this.prgBarraProgreso.Click += new System.EventHandler(this.prgBarraProgreso_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 344);
            this.Controls.Add(this.prgBarraProgreso);
            this.Controls.Add(this.pctSeguro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Bienvenido!";
            ((System.ComponentModel.ISupportInitialize)(this.pctSeguro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctSeguro;
        private System.Windows.Forms.Timer tmrReloj;
        private System.Windows.Forms.ProgressBar prgBarraProgreso;
    }
}

