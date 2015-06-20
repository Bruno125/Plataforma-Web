using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindForms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(System.Windows.Forms.Form frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Sistema Northwind";
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new NorthwindForms.Mantenimiento.FrmManCategoria());
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new NorthwindForms.Mantenimiento.FrmManProveedor());
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new NorthwindForms.Mantenimiento.FrmManProducto());
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new NorthwindForms.Mantenimiento.FrmManUsuario());
        }
    }
}
