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
    public partial class FrmManProducto : NorthwindForms.Base.FrmBase
    {
        private ProductsBusiness ProductsBusiness = ProductsBusiness.ObtenerInstancia();
        private CategoriesBusiness CategoriesBusiness = CategoriesBusiness.ObtenerInstancia();
        List<ProductsDto> Productos;
        List<CategoriesDto> Categorias;
        public FrmManProducto()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            this.TxtCodigo.Text = String.Empty;
            this.TxtNombre.Text = String.Empty;
            this.ComboCategoria.SelectedIndex = 0;
            this.TxtUnitOrder.Text = String.Empty;
            this.TxtUnitPrice.Text = String.Empty;
            this.TxtUnitStock.Text = String.Empty;
            this.TxtSupplier.Text = String.Empty;
            this.TxtReorder.Text = String.Empty;
            this.ChbDiscontinued.Checked = false;
        }

        private void LlenarDatagrid()
        {
            Productos = ProductsBusiness.Listar();
            this.DgvPrincipal.DataSource = Productos;
            int NumCols = this.DgvPrincipal.ColumnCount;
            foreach (DataGridViewColumn Col in this.DgvPrincipal.Columns)
            {
                Col.Visible = (Col.Name.Equals("ID") || Col.Name.Equals("Nombre") 
                    || Col.Name.Equals("Categoria"));
            }

            Categorias = CategoriesBusiness.Listar();
            this.ComboCategoria.DataSource = Categorias;

        }

        private void FrmManProducto_Load(object sender, EventArgs e)
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

        private void DgvPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.EsNuevo = false;
                this.TbcPrincipal.SelectedIndex = 1;

                //ProductsDto ProductsDto = Productos[e.RowIndex];
                ProductsDto ProductsDto = 
                    ProductsBusiness.Obtener(Convert.ToInt32(DgvPrincipal.Rows[e.RowIndex].Cells[0].Value));

                this.TxtCodigo.Text = ProductsDto.ProductID.ToString();
                this.TxtNombre.Text = ProductsDto.ProductName;
                this.TxtUnitOrder.Text = ProductsDto.UnitsOnOrder.ToString();
                this.TxtUnitPrice.Text = ProductsDto.UnitPrice.ToString();
                this.TxtUnitStock.Text = ProductsDto.UnitsOnOrder.ToString();
                this.TxtSupplier.Text = ProductsDto.SupplierID.ToString();
                this.TxtReorder.Text = ProductsDto.ReorderLevel.ToString();
                this.ChbDiscontinued.Checked = ProductsDto.Discontinued;

                this.ComboCategoria.SelectedIndex = GetCategorieIndex(ProductsDto.CategoryID);
            }
        }

        private int GetCategorieIndex(int id)
        {
            for(int i = 0; i < Categorias.Count ; i++)
                if(Categorias[i].CategoryID==id)
                    return i;
            return -1;
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
                    ProductsDto.SupplierID = Convert.ToInt32(this.TxtSupplier.Text.Trim());
                    ProductsDto.UnitPrice = Convert.ToInt32(this.TxtUnitPrice.Text.Trim());
                    ProductsDto.UnitsInStock = Convert.ToInt32(this.TxtUnitStock.Text.Trim());
                    ProductsDto.UnitsOnOrder = Convert.ToInt32(this.TxtUnitOrder.Text.Trim());
                    ProductsDto.ReorderLevel = Convert.ToInt32(this.TxtReorder.Text.Trim());
                    ProductsDto.Discontinued = this.ChbDiscontinued.Checked;
                    ProductsDto.CategoryID = Categorias[this.ComboCategoria.SelectedIndex].CategoryID;

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


    }
}
