namespace prySvetlizaIE
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lblExpediente = new System.Windows.Forms.Label();
            this.lblLiquidador = new System.Windows.Forms.Label();
            this.lblJuzgado = new System.Windows.Forms.Label();
            this.lblJurisdiccion = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.grpAltaProveedores = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.lblApertura = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtLiquidador = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtJurisdiccion = new System.Windows.Forms.TextBox();
            this.txtJuzgado = new System.Windows.Forms.TextBox();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.CNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEntidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CExpediente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CJuzgado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CJurisdiccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLiquidador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.grpAltaProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Location = new System.Drawing.Point(179, 27);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(51, 16);
            this.lblEntidad.TabIndex = 0;
            this.lblEntidad.Tag = "";
            this.lblEntidad.Text = "Entidad";
            // 
            // lblExpediente
            // 
            this.lblExpediente.AutoSize = true;
            this.lblExpediente.Location = new System.Drawing.Point(546, 27);
            this.lblExpediente.Name = "lblExpediente";
            this.lblExpediente.Size = new System.Drawing.Size(106, 16);
            this.lblExpediente.TabIndex = 1;
            this.lblExpediente.Text = "N° de expediente";
            // 
            // lblLiquidador
            // 
            this.lblLiquidador.AutoSize = true;
            this.lblLiquidador.Location = new System.Drawing.Point(546, 147);
            this.lblLiquidador.Name = "lblLiquidador";
            this.lblLiquidador.Size = new System.Drawing.Size(140, 16);
            this.lblLiquidador.TabIndex = 2;
            this.lblLiquidador.Text = "Liquidador responsable";
            // 
            // lblJuzgado
            // 
            this.lblJuzgado.AutoSize = true;
            this.lblJuzgado.Location = new System.Drawing.Point(6, 147);
            this.lblJuzgado.Name = "lblJuzgado";
            this.lblJuzgado.Size = new System.Drawing.Size(55, 16);
            this.lblJuzgado.TabIndex = 3;
            this.lblJuzgado.Text = "Juzgado";
            // 
            // lblJurisdiccion
            // 
            this.lblJurisdiccion.AutoSize = true;
            this.lblJurisdiccion.Location = new System.Drawing.Point(179, 147);
            this.lblJurisdiccion.Name = "lblJurisdiccion";
            this.lblJurisdiccion.Size = new System.Drawing.Size(75, 16);
            this.lblJurisdiccion.TabIndex = 4;
            this.lblJurisdiccion.Text = "Jurisdicción";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(360, 147);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(61, 16);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección";
            // 
            // grpAltaProveedores
            // 
            this.grpAltaProveedores.Controls.Add(this.txtNumero);
            this.grpAltaProveedores.Controls.Add(this.txtApertura);
            this.grpAltaProveedores.Controls.Add(this.lblApertura);
            this.grpAltaProveedores.Controls.Add(this.lblNumero);
            this.grpAltaProveedores.Controls.Add(this.txtLiquidador);
            this.grpAltaProveedores.Controls.Add(this.txtDireccion);
            this.grpAltaProveedores.Controls.Add(this.txtJurisdiccion);
            this.grpAltaProveedores.Controls.Add(this.txtJuzgado);
            this.grpAltaProveedores.Controls.Add(this.txtExpediente);
            this.grpAltaProveedores.Controls.Add(this.txtEntidad);
            this.grpAltaProveedores.Controls.Add(this.lblEntidad);
            this.grpAltaProveedores.Controls.Add(this.lblLiquidador);
            this.grpAltaProveedores.Controls.Add(this.lblDireccion);
            this.grpAltaProveedores.Controls.Add(this.lblExpediente);
            this.grpAltaProveedores.Controls.Add(this.lblJurisdiccion);
            this.grpAltaProveedores.Controls.Add(this.lblJuzgado);
            this.grpAltaProveedores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAltaProveedores.Location = new System.Drawing.Point(12, 12);
            this.grpAltaProveedores.Name = "grpAltaProveedores";
            this.grpAltaProveedores.Size = new System.Drawing.Size(723, 252);
            this.grpAltaProveedores.TabIndex = 6;
            this.grpAltaProveedores.TabStop = false;
            this.grpAltaProveedores.Text = "Alta proveedores";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(9, 65);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(142, 22);
            this.txtNumero.TabIndex = 15;
            // 
            // txtApertura
            // 
            this.txtApertura.Location = new System.Drawing.Point(363, 65);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(142, 22);
            this.txtApertura.TabIndex = 14;
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Location = new System.Drawing.Point(360, 27);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(56, 16);
            this.lblApertura.TabIndex = 13;
            this.lblApertura.Text = "Apertura";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(6, 27);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(21, 16);
            this.lblNumero.TabIndex = 12;
            this.lblNumero.Text = "N°";
            // 
            // txtLiquidador
            // 
            this.txtLiquidador.Location = new System.Drawing.Point(549, 188);
            this.txtLiquidador.Name = "txtLiquidador";
            this.txtLiquidador.Size = new System.Drawing.Size(142, 22);
            this.txtLiquidador.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(363, 188);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(142, 22);
            this.txtDireccion.TabIndex = 10;
            // 
            // txtJurisdiccion
            // 
            this.txtJurisdiccion.Location = new System.Drawing.Point(182, 188);
            this.txtJurisdiccion.Name = "txtJurisdiccion";
            this.txtJurisdiccion.Size = new System.Drawing.Size(142, 22);
            this.txtJurisdiccion.TabIndex = 9;
            // 
            // txtJuzgado
            // 
            this.txtJuzgado.Location = new System.Drawing.Point(9, 188);
            this.txtJuzgado.Name = "txtJuzgado";
            this.txtJuzgado.Size = new System.Drawing.Size(142, 22);
            this.txtJuzgado.TabIndex = 8;
            // 
            // txtExpediente
            // 
            this.txtExpediente.Location = new System.Drawing.Point(549, 65);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(142, 22);
            this.txtExpediente.TabIndex = 7;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(182, 65);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(142, 22);
            this.txtEntidad.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(396, 282);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 32);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModificar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.Location = new System.Drawing.Point(519, 282);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 32);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(636, 282);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 32);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVolver.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVolver.Location = new System.Drawing.Point(12, 554);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 32);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CNumero,
            this.CEntidad,
            this.CApertura,
            this.CExpediente,
            this.CJuzgado,
            this.CJurisdiccion,
            this.CDireccion,
            this.CLiquidador});
            this.dgvProveedores.Location = new System.Drawing.Point(12, 333);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.Size = new System.Drawing.Size(736, 195);
            this.dgvProveedores.TabIndex = 15;
            // 
            // CNumero
            // 
            this.CNumero.HeaderText = "N°";
            this.CNumero.Name = "CNumero";
            // 
            // CEntidad
            // 
            this.CEntidad.HeaderText = "Entidad";
            this.CEntidad.Name = "CEntidad";
            // 
            // CApertura
            // 
            this.CApertura.HeaderText = "Apertura";
            this.CApertura.Name = "CApertura";
            // 
            // CExpediente
            // 
            this.CExpediente.HeaderText = "N° expediente";
            this.CExpediente.Name = "CExpediente";
            // 
            // CJuzgado
            // 
            this.CJuzgado.HeaderText = "Juzgado";
            this.CJuzgado.Name = "CJuzgado";
            // 
            // CJurisdiccion
            // 
            this.CJurisdiccion.HeaderText = "Jurisdicción";
            this.CJurisdiccion.Name = "CJurisdiccion";
            // 
            // CDireccion
            // 
            this.CDireccion.HeaderText = "Dirección";
            this.CDireccion.Name = "CDireccion";
            // 
            // CLiquidador
            // 
            this.CLiquidador.HeaderText = "Liquidador responsable";
            this.CLiquidador.Name = "CLiquidador";
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMostrar.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMostrar.Location = new System.Drawing.Point(636, 545);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(90, 32);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 598);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grpAltaProveedores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta proveedores";
            this.grpAltaProveedores.ResumeLayout(false);
            this.grpAltaProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label lblExpediente;
        private System.Windows.Forms.Label lblLiquidador;
        private System.Windows.Forms.Label lblJuzgado;
        private System.Windows.Forms.Label lblJurisdiccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.GroupBox grpAltaProveedores;
        public System.Windows.Forms.TextBox txtLiquidador;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtJurisdiccion;
        public System.Windows.Forms.TextBox txtJuzgado;
        public System.Windows.Forms.TextBox txtExpediente;
        public System.Windows.Forms.TextBox txtEntidad;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnVolver;
        public System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Label lblNumero;
        public System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEntidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn CExpediente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CJuzgado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CJurisdiccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLiquidador;
        public System.Windows.Forms.Button btnMostrar;
    }
}