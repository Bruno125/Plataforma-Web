using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Importaciones
using NorthwindEntity.Entity;
using NorthwindBusiness.Business;
using NorthwindWeb.Util;

namespace NorthwindWeb.Pages.Categoria {
    public partial class ActCategoria : System.Web.UI.Page {

        private CategoriesBusiness CategoriesBusiness = CategoriesBusiness.ObtenerInstancia();

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) { 
                string Id = Request.QueryString["id"];
                if (Id == null) 
                {
                    this.BtnActualizar.Enabled = false;
                    this.LblMensaje.Text = "No ha seleccionado un ID valido";
                } else 
                {
                    int CategoryId;
                    if (int.TryParse(Id.Trim(), out CategoryId)) 
                    {
                        CategoriesDto CategoriesDto = CategoriesBusiness.Obtener(CategoryId);
                        if (CategoriesDto.CategoryName != null) 
                        {
                            this.TxtCodigo.Text = Id;
                            this.TxtNombre.Text = CategoriesDto.CategoryName.ToUpper();
                            this.TxtDescripcion.Text = CategoriesDto.Description.ToUpper();
                            this.BtnActualizar.Enabled = true;
                        } else 
                        {
                            this.BtnActualizar.Enabled = false;
                            this.LblMensaje.Text = "No existe una Categoria con ese ID";
                        }
                    } else {
                        this.BtnActualizar.Enabled = false;
                        this.LblMensaje.Text = "No ha seleccionado un ID valido";
                    }
                }
            }
        }

        protected void BtnActualizar_Click(object sender, EventArgs e) {
            try {
                CategoriesDto CategoriesDto = new CategoriesDto();
                CategoriesDto.CategoryID = Convert.ToInt32(this.TxtCodigo.Text);
                CategoriesDto.CategoryName = this.TxtNombre.Text.Trim().ToUpper();
                CategoriesDto.Description = this.TxtDescripcion.Text.Trim().ToUpper();
                CategoriesBusiness.Actualizar(CategoriesDto);
                this.LblMensaje.Text = string.Format(ConstantesWeb.EXITO_ACTUALIZAR, "Categoria");
            } catch (Exception Ex) {
                this.LblMensaje.Text = "Ocurrio un error: " + Ex.Message;
            }
        }
    }
}