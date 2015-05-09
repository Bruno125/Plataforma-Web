using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Importaciones
using NorthwindForms.Mantenimiento;

namespace NorthwindForms
{
    public partial class FrmPrincipal : Form
    {
        private void AbrirFormulario(Form Form)
        {
            Form.MdiParent = this;
            Form.Show();
        }

        private void Habilitar()
        {
            categoriaToolStripMenuItem.Visible = false;
            productoToolStripMenuItem.Visible = false;
        }
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmManCategoria());
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
