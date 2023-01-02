using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablero
{
    internal class VALIDAD
    {
        public  static bool txtValidarNuevo(TextBox ptxt)
        {
            if (ptxt.Text == string.Empty)
            {
                ptxt.Focus();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
