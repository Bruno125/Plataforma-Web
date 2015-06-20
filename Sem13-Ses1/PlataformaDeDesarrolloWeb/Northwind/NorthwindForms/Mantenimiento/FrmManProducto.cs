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
    public partial class FrmManProducto : NorthwindForms.Base.FrmBase
    {

        private ProductsBusiness ProductsBusiness = ProductsBusiness.ObtenerInstancia();
        private CategoriesBusiness CategoriesBusiness = CategoriesBusiness.ObtenerInstancia();
 
        private void LlenarDatagrid()
        {
            this.DgvPrincipal.AutoGenerateColumns = false;
            this.DgvPrincipal.DataSource = ProductsBusiness.Listar();
        }

        private void LlenarCombo()
        {
            this.CboCategoria.DataSource = CategoriesBusiness.Listar();
            this.CboCategoria.DisplayMember = "CategoryName";
            this.CboCategoria.ValueMember = "CategoryID";
        }

        private void Limpiar()
        {
            this.TxtCodigo.Text = String.Empty;
            this.TxtNombre.Text = String.Empty;
            this.CboCategoria.SelectedIndex = 0;
            this.TxtUnidad.Text = string.Empty;
            this.NudOrdenar.Value = 0;
            this.NudPedidos.Value = 0;
            this.NudPu.Value = 0;
            this.NudStock.Value = 0;
        }

        public FrmManProducto()
        {
            InitializeComponent();
        }

        private void FrmManProducto_Load(object sender, EventArgs e)
        {
            this.LlenarDatagrid();
            this.LlenarCombo();
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.DgvPrincipal.SelectedRows[0].Index >= 0)
                {
                    ProductsBusiness.Eliminar(Int32.Parse(DgvPrincipal.Rows[DgvPrincipal.SelectedRows[0].Index].Cells[0].Value.ToString()));
                    this.LlenarDatagrid();
                    UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_ELIMINAR, "Producto"));

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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsNuevo)
                {
                    ProductsDto ProductsDto = new ProductsDto();
                    ProductsDto.ProductName = this.TxtNombre.Text.Trim().ToUpper();
                    ProductsDto.SupplierID = 1;
                    ProductsDto.CategoryID =Convert.ToInt32(this.CboCategoria.SelectedValue);
                    ProductsDto.QuantityPerUnit = this.TxtUnidad.Text.Trim();
                    ProductsDto.UnitPrice = this.NudPu.Value;
                    ProductsDto.UnitsInStock =(int)this.NudStock.Value;
                    ProductsDto.UnitsOnOrder = (int)this.NudPedidos.Value;
                    ProductsDto.ReorderLevel = (int)this.NudOrdenar.Value;
                    ProductsDto.Discontinued = this.ChkDiscontinuado.Checked;
                    if (this.TxtCodigo.Text.Length <= 0)
                    {
                        this.ProductsBusiness.Insertar(ProductsDto);
                        UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_GUARDAR, "Producto"));
                        this.Limpiar();
                        this.TxtNombre.Focus();
                    }
                    else
                    {
                        ProductsDto.ProductID = Int32.Parse(this.TxtCodigo.Text);
                        this.ProductsBusiness.Actualizar(ProductsDto);
                        UtilForms.MensajeExito(this, string.Format(Constantes.EXITO_ACTUALIZAR, "Producto"));
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.EsNuevo = true;
            this.TbcPrincipal.SelectedIndex = 0;
        }

        private void TbcPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EsNuevo && TbcPrincipal.SelectedIndex != 0)
            {
                this.TbcPrincipal.SelectedIndex = 0;
                UtilForms.MensajeInformativo(this);
            }
        }

        private void DgvPrincipal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.EsNuevo = false;
                ProductsDto ProductsDto = ProductsBusiness.Obtener(Convert.ToInt32(DgvPrincipal.Rows[e.RowIndex].Cells[0].Value.ToString()));
                this.TxtCodigo.Text = Convert.ToString(ProductsDto.ProductID);
                this.TxtNombre.Text = ProductsDto.ProductName.ToUpper();
                this.CboCategoria.SelectedValue = ProductsDto.CategoryID;
                this.TxtUnidad.Text = ProductsDto.QuantityPerUnit;
                this.NudPu.Value = ProductsDto.UnitPrice;
                this.NudStock.Value = ProductsDto.UnitsInStock;
                this.NudPedidos.Value = ProductsDto.UnitsOnOrder;
                this.NudOrdenar.Value = ProductsDto.ReorderLevel;
                this.ChkDiscontinuado.Checked = ProductsDto.Discontinued;
                this.TbcPrincipal.SelectedIndex = 1;
            }
        }
    }
}
