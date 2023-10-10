namespace prySvetlizaIE
{
    partial class frmMostrar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrar));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trvProveedores = new System.Windows.Forms.TreeView();
            this.imgCarpetas = new System.Windows.Forms.ImageList(this.components);
            this.btnVolver = new System.Windows.Forms.Button();
            this.lsvProveedores = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trvProveedores);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnVolver);
            this.splitContainer1.Panel2.Controls.Add(this.lsvProveedores);
            this.splitContainer1.Size = new System.Drawing.Size(945, 415);
            this.splitContainer1.SplitterDistance = 314;
            this.splitContainer1.TabIndex = 0;
            // 
            // trvProveedores
            // 
            this.trvProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvProveedores.ImageIndex = 0;
            this.trvProveedores.ImageList = this.imgCarpetas;
            this.trvProveedores.Location = new System.Drawing.Point(0, 0);
            this.trvProveedores.Name = "trvProveedores";
            this.trvProveedores.SelectedImageIndex = 0;
            this.trvProveedores.Size = new System.Drawing.Size(314, 415);
            this.trvProveedores.TabIndex = 0;
            // 
            // imgCarpetas
            // 
            this.imgCarpetas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCarpetas.ImageStream")));
            this.imgCarpetas.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCarpetas.Images.SetKeyName(0, "carpeta.png");
            this.imgCarpetas.Images.SetKeyName(1, "imagen de documento.png");
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVolver.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.Location = new System.Drawing.Point(525, 380);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 32);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lsvProveedores
            // 
            this.lsvProveedores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvProveedores.HideSelection = false;
            this.lsvProveedores.Location = new System.Drawing.Point(2, 3);
            this.lsvProveedores.Name = "lsvProveedores";
            this.lsvProveedores.Size = new System.Drawing.Size(622, 371);
            this.lsvProveedores.SmallImageList = this.imgCarpetas;
            this.lsvProveedores.TabIndex = 0;
            this.lsvProveedores.UseCompatibleStateImageBehavior = false;
            this.lsvProveedores.View = System.Windows.Forms.View.Details;
            this.lsvProveedores.SelectedIndexChanged += new System.EventHandler(this.lsvProveedores_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 113;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            this.columnHeader2.Width = 128;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Última modificación";
            this.columnHeader3.Width = 373;
            // 
            // frmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 415);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar proveedores";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trvProveedores;
        private System.Windows.Forms.ListView lsvProveedores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imgCarpetas;
        public System.Windows.Forms.Button btnVolver;
    }
}