using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Configuration;
using System.Windows.Forms;

namespace Tablero
{
    public class DBoracle
    {

        string conexionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        public void conectar()
        {
            OracleConnection ora = new OracleConnection("DATA SOURCE = CONEXION_CLIENT ; PASSWORD = Adan1234 ; USER ID = SYSTEM;");
            ora.Open();
            MessageBox.Show("Conectado");

        }

    }
}
