using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Importaciones
using NorthwindBusiness.Business;
using NorthwindEntity.Entity;

namespace NorthwindWeb.Pages.Categoria {
    public partial class RegCategoria : System.Web.UI.Page {

        private CategoriesBusiness CategoriesBusiness = CategoriesBusiness.ObtenerInstancia();

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void BtnRegistrar_Click(object sender, EventArgs e) {
            try {
                CategoriesDto CategoriesDto = new CategoriesDto();
                CategoriesDto.CategoryName = this.TxtNombre.Text.ToUpper();
                CategoriesDto.Description = this.TxtDescipcion.Text.ToUpper();
                CategoriesBusiness.Insertar(CategoriesDto);
                this.LblMensaje.Text = string.Format(
                    NorthwindWeb.Util.ConstantesWeb.EXITO_GUARDAR, "Categoria");
            } catch (Exception Ex) {
                this.LblMensaje.Text = "Ocurrio un error: " + Ex.Message;
            }
        }
    }
}