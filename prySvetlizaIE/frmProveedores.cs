using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prySvetlizaIE
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        int Guia = 6;

        clsGrabado grabado = new clsGrabado();
        private void frmMostrarProveedor_Load(object sender, EventArgs e)
        {

            txtNumero.Text = Guia.ToString();
        }


        public void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtEntidad.Text == "")
            {
                MessageBox.Show("Campo Entidad vacio");
                txtEntidad.Focus();
            }
            else
            {
                if (txtApertura.Text == "")
                {
                    MessageBox.Show("Campo Apertura vacio");
                    txtApertura.Focus();
                }
                else
                {
                    if (txtExpediente.Text == "")
                    {
                        MessageBox.Show("Campo número de expediente vacio");
                        txtExpediente.Focus();
                    }
                    else
                    {
                        if (txtJuzgado.Text == "")
                        {
                            MessageBox.Show("Campo Juzgado vacio");
                            txtJuzgado.Focus();
                        }
                        else
                        {
                            if (txtJurisdiccion.Text == "")
                            {
                                MessageBox.Show("Campo Jurisdiccion vacio");
                                txtJurisdiccion.Focus();
                            }
                            else
                            {
                                if (txtDireccion.Text == "")
                                {
                                    MessageBox.Show("Campo Direccion vacio");
                                    txtDireccion.Focus();
                                }
                                else
                                {
                                    if (txtLiquidador.Text == "")
                                    {
                                        MessageBox.Show("Campo Liquidador responsable vacio");
                                        txtLiquidador.Focus();
                                    }
                                    else
                                    {
                                        string[] datosProveedores = new string[] { Guia.ToString(), txtEntidad.Text, txtApertura.Text, txtExpediente.Text, txtJuzgado.Text, txtJurisdiccion.Text, txtDireccion.Text, txtLiquidador.Text };

                                        string datosConcatenados = string.Join(";", datosProveedores);

                                        grabado.Grabar(datosConcatenados);

                                        Guia++;
                                        txtNumero.Text = Guia.ToString();
                                        txtEntidad.Clear();
                                        txtApertura.Clear();
                                        txtExpediente.Clear();
                                        txtJuzgado.Clear();
                                        txtJurisdiccion.Clear();
                                        txtDireccion.Clear();
                                        txtLiquidador.Clear();
                                        MessageBox.Show("Nuevo proveedor registrado!");
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void ControlarCajasDeTexto()
        {


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            fmrPrincipal Principal = new fmrPrincipal();
            Principal.ShowDialog();
            this.Close();
        }
        string leerLinea;
        string[] separarDatos;
        private bool grilla = false;
        public static int pos = 0;
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (!grilla)
            {

                StreamReader sr = new StreamReader(@"../../Resources/datosProveedorConPuntoComa");

                string leerLinea;

                string[] separarDatos;
                
                  leerLinea = sr.ReadLine();
                
                separarDatos = leerLinea.Split(';');
                
                for (int indice = 0; indice < separarDatos.Length; indice++)
                {
                    
                      dgvProveedores.Columns.Add(separarDatos[indice], separarDatos[indice]);
                }
                
                while (sr.EndOfStream == false)
                {
                     leerLinea = sr.ReadLine();                   
                    separarDatos = leerLinea.Split(';');
                    
                    dgvProveedores.Rows.Add(separarDatos);
                }
                
                sr.Close();
                
                grilla = true;
            }
        }
    }
}
