using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Importaciones
using NorthwindBusiness.Business;
using NorthwindEntity.Entity;
using NorthwindForms.Util;

namespace NorthwindForms.Mantenimiento
{
    public partial class FrmManProveedor : NorthwindForms.Base.FrmBase
    {
        private ProvidersBusiness ProvidersBusiness = ProvidersBusiness.ObtenerInstancia();

        private void LlenarDatagrid()
        {
            this.DgvPrincipal.DataSource = ProvidersBusiness.Listar();
        }

        private void Limpiar()
        {
            this.TxtCodigo.Text = string.Empty;
            this.TxtNombre.Text = string.Empty;
            this.TxtDescripcion.Text = string.Empty;
        }
        public FrmManProveedor()
        {
            InitializeComponent();
        }

        private void FrmManProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                this.LlenarDatagrid();
            }
            catch (Exception Ex)
            {
                UtilForms.MensajeError(this,string.Format(Constantes.ERROR,Ex.Message));
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = false;
            this.Limpiar();
            this.TbcPrincipal.SelectedIndex = 1;
            this.TxtNombre.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsNuevo)
                {
                    ProvidersDto ProvidersDto = new ProvidersDto();
                    ProvidersDto.Name = this.TxtNombre.Text.Trim().ToUpper();
                    ProvidersDto.Description = this.TxtDescripcion.Text.Trim().ToUpper();
                    if (this.TxtCodigo.Text.Length <= 0)
                    {
                        this.ProvidersBusiness.Insertar(ProvidersDto);
                        UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_GUARDAR, "Proveedor"));
                        this.Limpiar();
                    }
                    else
                    {
                        ProvidersDto.ProvidersId = Convert.ToInt32(this.TxtCodigo.Text);
                        this.ProvidersBusiness.Actualizar(ProvidersDto);
                        UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_ACTUALIZAR, "Proveedor"));
                    }
                    this.TxtNombre.Focus();
                    this.LlenarDatagrid();
                }
            }
            catch (Exception Ex)
            {

                UtilForms.MensajeError(this, string.Format(Constantes.ERROR, Ex.Message));
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
            if (e.RowIndex >= 0)
            {
                this.EsNuevo = false;
                this.TxtCodigo.Text = DgvPrincipal.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.TxtNombre.Text = DgvPrincipal.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.TxtDescripcion.Text = DgvPrincipal.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.TbcPrincipal.SelectedIndex = 1;
            }
        }

        private void TbcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EsNuevo && TbcPrincipal.SelectedIndex != 0)
            {
                this.TbcPrincipal.SelectedIndex = 0;
                UtilForms.MensajeInformativo(this);
            }
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DgvPrincipal.SelectedRows[0].Index >= 0)
                {
                    ProvidersBusiness.Eliminar(Convert.ToInt32(
                        DgvPrincipal.Rows[DgvPrincipal.SelectedRows[0].Index].Cells[0].Value.ToString()));
                    this.LlenarDatagrid();
                    UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_ELIMINAR, "Proveedor"));
                    this.EsNuevo = true;
                    this.Limpiar();
                }
            }
            catch (Exception Ex)
            {
                UtilForms.MensajeError(this, string.Format(Constantes.ERROR, Ex.Message));
            }
        }
    }
}
