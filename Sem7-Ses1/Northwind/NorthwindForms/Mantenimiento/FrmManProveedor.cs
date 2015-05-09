using NorthwindBusiness.Business;
using NorthwindEntity.Entity;
using NorthwindForms.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NorthwindForms.Mantenimiento
{
    public partial class FrmManProveedor : NorthwindForms.Base.FrmBase
    {
        private ProviderBusiness ProviderBusiness = ProviderBusiness.ObtenerInstancia();
        private bool EsNuevo = true;

        public FrmManProveedor()
        {
            InitializeComponent();
        }

        private void LlenarDatagrid()
        {
            this.DgvPrincipal.DataSource = ProviderBusiness.Listar();
        }

        private void Limpiar()
        {
            this.TxtCodigo.Text = string.Empty;
            this.TxtNombre.Text = string.Empty;
            this.TxtDescripcion.Text = string.Empty;
        }

        private void FrmManProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                this.LlenarDatagrid();
            }
            catch (Exception E)
            {
                UtilForms.MensajeError(this,string.Format(Constantes.ERROR,E.Message));
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            this.EsNuevo = false;
            this.Limpiar();
            this.TbpPrincipal.SelectedIndex = 1;
            this.TxtNombre.Focus();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsNuevo)
                {
                    ProviderDto ProviderDto = new ProviderDto();
                    ProviderDto.Name = this.TxtNombre.Text.Trim().ToUpper();
                    ProviderDto.Description = this.TxtDescripcion.Text.Trim().ToUpper();
                    if (TxtCodigo.Text.Length <= 0)
                    {
                        //Insertando
                        ProviderBusiness.Insertar(ProviderDto);
                        UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_GUARDAR, "Proveedor"));
                        this.Limpiar();
                    }
                    else
                    {
                        //Actualizando
                        ProviderDto.ProviderId = Int32.Parse(this.TxtCodigo.Text);
                        ProviderBusiness.Actualizar(ProviderDto);
                        UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_ACTUALIZAR, "Proveedor"));
                    }
                    this.TxtNombre.Focus();
                    this.LlenarDatagrid();
                }
            }
            catch (Exception E)
            {
                UtilForms.MensajeError(this, string.Format(Constantes.ERROR, E.Message));
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.EsNuevo = true;
            this.TbpPrincipal.SelectedIndex = 0;
        }

        private void DgvPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                this.EsNuevo = false;
                this.TxtCodigo.Text = DgvPrincipal.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.TxtNombre.Text = DgvPrincipal.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.TxtDescripcion.Text = DgvPrincipal.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.TbpPrincipal.SelectedIndex = 1;
            }
        }

        private void TbpPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EsNuevo && TbpPrincipal.SelectedIndex != 0)
            {
                this.TbpPrincipal.SelectedIndex = 0;
                UtilForms.MensajeInformativo(this);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = this.DgvPrincipal.SelectedRows[0].Index;
                if (selectedIndex >= 0)
                {
                    ProviderBusiness.Eliminar(Convert.ToInt32(
                        this.DgvPrincipal.Rows[selectedIndex].Cells[0].Value.ToString()));
                    this.LlenarDatagrid();
                    UtilForms.MensajeExito(this,string.Format(Constantes.EXITO_ELIMINAR,"Proveedor"));
                    this.EsNuevo = true;
                    this.Limpiar();
                }
            }
            catch (Exception E)
            {
                UtilForms.MensajeError(this, string.Format(Constantes.ERROR, E.Message));
            }
        }

    }
}
