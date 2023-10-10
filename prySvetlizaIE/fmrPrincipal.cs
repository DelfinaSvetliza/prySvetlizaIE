using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySvetlizaIE
{
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
        }

        private void mostrarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar frmMostrar = new frmMostrar();
            frmMostrar.ShowDialog();
            this.Close();
        }

        private void tsmAltaProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores frmProveedores = new frmProveedores();
            frmProveedores.ShowDialog();
            this.Close();
        }
    }
}
