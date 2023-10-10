using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prySvetlizaIE
{
    internal class clsCargaProveedor
    {
        public string NombreArchivo = "Nuevos_Proveedores.csv";

        public void Agregar(string entidad, string expediente, string juzgado, string jurisdiccion, string direccion, string liquidador)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo,true);
            AD.Write(entidad);
            AD.Write(";");
            AD.Write(expediente);
            AD.Write(";");
            AD.Write(juzgado);
            AD.Write(";");
            AD.Write(jurisdiccion);
            AD.Write(";");
            AD.Write(direccion);
            AD.Write(";");
            AD.WriteLine(liquidador);
            AD.Close();
            AD.Dispose();
        }
    }
}
