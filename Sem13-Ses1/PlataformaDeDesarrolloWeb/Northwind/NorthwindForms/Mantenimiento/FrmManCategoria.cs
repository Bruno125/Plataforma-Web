using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NorthwindBusiness.Business;
using NorthwindEntity.Entity;
using NorthwindForms.Util;

namespace NorthwindForms.Mantenimiento
{
    public partial class FrmManCategoria : NorthwindForms.Base.FrmBase
    {

        private CategoriesBusiness CategoriesBusiness = CategoriesBusiness.ObtenerInstancia();
        
        private void Limpiar()
        {
            this.TxtCodigo.Text = String.Empty;
            this.TxtNombre.Text = String.Empty;
            this.TxtDescripcion.Text = String.Empty;
        }

        private void LlenarDatagrid()
        {
            this.DgvPrincipal.DataSource = CategoriesBusiness.Listar();
            this.DgvPrincipal.Columns["Picture"].Visible = false;
        }


        public FrmManCategoria()
        {
            InitializeComponent();
        }

        
        private void FrmManCategoria_Load(object sender, EventArgs e)
        {
            this.LlenarDatagrid();
        }

        
        
        private void TbcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EsNuevo && TbcPrincipal.SelectedIndex != 0)
            {
                this.TbcPrincipal.SelectedIndex = 0;
                UtilForms.MensajeInformativo(this);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.EsNuevo = true;
            this.TbcPrincipal.SelectedIndex = 0;
        }

        private void DgvPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) { 
                this.EsNuevo = false;
                this.TxtCodigo.Text = DgvPrincipal.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.TxtNombre.Text = DgvPrincipal.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.TxtDescripcion.Text = DgvPrincipal.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.TbcPrincipal.SelectedIndex = 1;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!EsNuevo)
                {
                    CategoriesDto CategoriesDto = new CategoriesDto();
                    CategoriesDto.CategoryName = this.TxtNombre.Text.Trim().ToUpper();
                    CategoriesDto.Description = this.TxtDescripcion.Text.Trim().ToUpper();
                    if (this.TxtCodigo.Text.Length <= 0)
                    {
                        this.CategoriesBusiness.Insertar(CategoriesDto);
                        UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_GUARDAR, "Categoria"));
                        this.Limpiar();
                        this.TxtNombre.Focus();
                    }
                    else
                    {
                        CategoriesDto.CategoryID = Int32.Parse(this.TxtCodigo.Text);
                        this.CategoriesBusiness.Actualizar(CategoriesDto);
                        UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_ACTUALIZAR, "Categoria"));
                        this.TxtNombre.Focus();
                    }
                    this.LlenarDatagrid();
                }
               
            }
            catch (Exception E)
            {
                UtilForms.MensajeError(this, string.Format(Constantes.ERROR, E.Message));
            }
            
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = false;
            this.Limpiar();
            this.TbcPrincipal.SelectedIndex = 1;
            this.TxtNombre.Focus();
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DgvPrincipal.SelectedRows[0].Index >= 0)
                {
                    CategoriesBusiness.Eliminar(Int32.Parse(DgvPrincipal.Rows[DgvPrincipal.SelectedRows[0].Index].Cells[0].Value.ToString()));
                    this.LlenarDatagrid();
                    UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_ELIMINAR, "Categoria"));

                }
            }
            catch (Exception E)
            {
                UtilForms.MensajeError(this, string.Format(Constantes.ERROR, E.Message));
            }
        }

    }
}

