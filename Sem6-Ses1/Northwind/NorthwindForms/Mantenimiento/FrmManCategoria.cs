using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Importaciones
using NorthwindEntity.Entity;
using NorthwindBusiness.Business;
using NorthwindForms.Util;

namespace NorthwindForms.Mantenimiento
{
    public partial class FrmManCategoria : NorthwindForms.Base.FrmBase
    {
        private CategoriesBusiness CategoriesBusiness = CategoriesBusiness.ObtenerInstancia();
        private bool EsNuevo = true;
        private void LlenarDatagrid()
        {
            this.DgvPrincipal.DataSource = CategoriesBusiness.Listar();
            this.DgvPrincipal.Columns["Picture"].Visible = false;
        }

        private void Limpiar()
        {
            this.TxtCodigo.Text = string.Empty;
            this.TxtNombre.Text = string.Empty;
            this.TxtDescripcion.Text = string.Empty;
        }


        public FrmManCategoria()
        {
            InitializeComponent();
        }

        private void FrmManCategoria_Load(object sender, EventArgs e)
        {
            this.LlenarDatagrid();
        }

        private void TbpPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EsNuevo && TbpPrincipal.SelectedIndex != 0)
            {
                this.TbpPrincipal.SelectedIndex = 0;
                UtilForms.MensajeInformativo(this);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.EsNuevo = true;
            this.TbpPrincipal.SelectedIndex = 0;
            this.LlenarDatagrid();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = false;
            this.Limpiar();
            this.TbpPrincipal.SelectedIndex = 1;
            this.TxtNombre.Focus();
        }

        private void DgvPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.EsNuevo = false;
                this.TxtCodigo.Text = DgvPrincipal.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.TxtNombre.Text = DgvPrincipal.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.TxtDescripcion.Text = DgvPrincipal.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.TbpPrincipal.SelectedIndex = 1;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvPrincipal.SelectedRows[0].Index >= 0)
                {
                    int IndiceSeleccionado = DgvPrincipal.SelectedRows[0].Index;
                    CategoriesBusiness.
                        Eliminar(Int32.Parse(DgvPrincipal.Rows[IndiceSeleccionado].Cells[0].Value.ToString()));
                    this.EsNuevo = true;
                    this.Limpiar();
                    this.LlenarDatagrid();
                }
            }
            catch (Exception E)
            {
                UtilForms.MensajeError(this, string.Format(Constantes.ERROR, E.Message));
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CategoriesDto CategoriesDto = new CategoriesDto();
                CategoriesDto.CategoryName = this.TxtNombre.Text.Trim().ToUpper();
                CategoriesDto.Description = this.TxtDescripcion.Text.Trim().ToUpper();
                if( TxtCodigo.Text.Length<=0)
                {
                    //Insertando
                    CategoriesBusiness.Insertar(CategoriesDto);
                    UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_GUARDAR, "Categoria"));
                    this.Limpiar();
                }
                else
                {  
                    //Actualizando
                    CategoriesDto.CategoryID = Int32.Parse(this.TxtCodigo.Text);
                    CategoriesBusiness.Actualizar(CategoriesDto);
                    UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_ACTUALIZAR, "Categoria"));
                }
                this.TxtNombre.Focus();
                this.LlenarDatagrid();

            }
            catch (Exception E)
            {

            }
        }

    }
}
