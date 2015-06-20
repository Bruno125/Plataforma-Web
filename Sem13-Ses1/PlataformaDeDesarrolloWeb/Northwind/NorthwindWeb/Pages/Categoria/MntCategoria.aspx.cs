using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Importaciones
using NorthwindBusiness.Business;
using NorthwindEntity.Entity;
using NorthwindWeb.Util;

namespace NorthwindWeb.Pages.Categoria {
    public partial class MntCategoria : System.Web.UI.Page {

        private CategoriesBusiness CategoriesBusiness 
            = CategoriesBusiness.ObtenerInstancia();

        private void LlenarGrid() {
            GvCategorias.DataSource = CategoriesBusiness.Listar();
            GvCategorias.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e) {
            LlenarGrid();
            LblMensaje.Text = "";
        }


        protected void GvCategorias_RowDeleting(object sender, 
            GridViewDeleteEventArgs e) {
                int Id = Convert.ToInt32(e.Values[0].ToString());
                CategoriesBusiness.Eliminar(Id);
                LlenarGrid();
                this.LblMensaje.Text = 
                    string.Format(ConstantesWeb.EXITO_ELIMINAR, 
                    "Categoria");
        }

        protected void GvCategorias_RowEditing(object sender, GridViewEditEventArgs e) {
            GridViewRow Row = GvCategorias.Rows[e.NewEditIndex];
            e.Cancel = true;
            Response.Redirect("/Pages/Categoria/ActCategoria.aspx?id=" +
                Row.Cells[0].Text);
        }
    }
}