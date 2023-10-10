using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace prySvetlizaIE
{
    internal class clsUsuarios
    {
        OleDbConnection conexionBaseDatos;

        public void abrirBaseDatos()
        {
            conexionBaseDatos = new OleDbConnection("C:\\Users\\delfina\\Desktop\\prySvetlizaIE\\Resources");

            conexionBaseDatos.Open();
        }
    }
}
