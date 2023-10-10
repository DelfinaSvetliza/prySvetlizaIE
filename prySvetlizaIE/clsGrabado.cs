using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prySvetlizaIE
{
    internal class clsGrabado
    {
        public void Grabar (string GrabarDatos)
        {
            StreamWriter sr = new StreamWriter("../../Resources/datosProveedorConPuntoComa", true);
            sr.WriteLine(GrabarDatos);
            sr.Close();
        }
    }
}
