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


namespace prySvetlizaIE
{
    public partial class frmMostrar : Form
    {
        private string numero, entidad, apertura, expediente, juzgado, jurisdiccion, direccion, liquidador;

        public string pnumero
        {
            set
            {
                numero = value;
            }
        }
        public string pentidad
        {
            set
            {
                entidad = value;
            }
        }

        public string papertura
        {
            set
            {
                apertura = value;
            }
        }
        public string pexpediente
        {
            set
            {
                expediente = value;
            }
        }
        public string pjuzgado
        {
            set
            {
                juzgado = value;
            }
        }

        public string pjurisdiccion
        {
            set
            {
                jurisdiccion = value;
            }
        }
        public string pdireccion
        {
            set
            {
                direccion = value;
            }
        }

        public string pliquidador
        {
            set
            {
                liquidador = value;
            }
        }
        public frmMostrar()
        {
            InitializeComponent();
            LlenarTreeView();
            this.trvProveedores.NodeMouseClick +=
            new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
        }

        private void LlenarTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"../../Resources/Proveedores");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                trvProveedores.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            lsvProveedores.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;
            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                    {new ListViewItem.ListViewSubItem(item, "Directory"),
             new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                lsvProveedores.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                    { new ListViewItem.ListViewSubItem(item, "File"),
             new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                lsvProveedores.Items.Add(item);
            }

            lsvProveedores.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
            private void lsvProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        public void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.ShowDialog();
            this.Close();
        }

       
        

        private void btnMostrar_Click(object sender, EventArgs e)
        {           

        }

        private void dgvProveedores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
