using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindForms.Util
{
    static class UtilForms
    {
        /**
         * params son los equivalentes a los varags de Java
         * */
        public static void MensajeInformativo(Form Form, params string[] Mensaje)
        {
            if (Mensaje != null && Mensaje.Length > 0)
            {
                MessageBox.Show(Form, Mensaje[0], "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(Form, Constantes.NO_SELECCIONO_ELEMENTO, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public static void MensajeExito(Form Form,String Mensaje)
        {
            MessageBox.Show(Form, Mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MensajeError(Form Form, String Mensaje)
        {
            MessageBox.Show(Form, Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
