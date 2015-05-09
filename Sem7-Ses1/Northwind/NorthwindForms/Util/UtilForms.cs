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
        /// <summary>
        /// Es un metodo comun en todos los formularios
        /// </summary>
        /// <param name="Form"></param>
        /// <param name="Mensaje">Es el equivalente a los vargs en Java</param>
        public static void MensajeInformativo(Form Form, params string[] Mensaje)
        {
            if (Mensaje != null && Mensaje.Length > 0)
            {
                MessageBox.Show(Form,Mensaje[0],"Informacion",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(Form, Constantes.NO_SELECCIONADO, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void MensajeExito(Form Form, string Mensaje)
        {
            MessageBox.Show(Form,Mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MensajeError(Form Form, string Mensaje)
        {
            MessageBox.Show(Form, Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
