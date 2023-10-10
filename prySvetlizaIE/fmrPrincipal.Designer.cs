namespace prySvetlizaIE
{
    partial class fmrPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrPrincipal));
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAltaProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnsPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProveedores});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(537, 24);
            this.mnsPrincipal.TabIndex = 1;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // tsmProveedores
            // 
            this.tsmProveedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAltaProveedores,
            this.mostrarProveedoresToolStripMenuItem});
            this.tsmProveedores.Name = "tsmProveedores";
            this.tsmProveedores.Size = new System.Drawing.Size(84, 20);
            this.tsmProveedores.Text = "proveedores";
            // 
            // tsmAltaProveedores
            // 
            this.tsmAltaProveedores.Name = "tsmAltaProveedores";
            this.tsmAltaProveedores.Size = new System.Drawing.Size(183, 22);
            this.tsmAltaProveedores.Text = "Alta proveedores";
            this.tsmAltaProveedores.Click += new System.EventHandler(this.tsmAltaProveedores_Click);
            // 
            // mostrarProveedoresToolStripMenuItem
            // 
            this.mostrarProveedoresToolStripMenuItem.Name = "mostrarProveedoresToolStripMenuItem";
            this.mostrarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.mostrarProveedoresToolStripMenuItem.Text = "Mostrar proveedores";
            this.mostrarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.mostrarProveedoresToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::prySvetlizaIE.Properties.Resources.logo_logica;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 347);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 371);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnsPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "fmrPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema gestion de proveedores";
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmProveedores;
        private System.Windows.Forms.ToolStripMenuItem tsmAltaProveedores;
        private System.Windows.Forms.ToolStripMenuItem mostrarProveedoresToolStripMenuItem;
    }
}