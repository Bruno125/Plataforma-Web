using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Importaciones
using NorthwindEntity.Entity;
using NorthwindWeb.Util;

namespace NorthwindWeb {
    public partial class Index : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (Request.Cookies["UsuarioCookie"] != null) {
                this.TxtUsuario.Text = Request.Cookies["UsuarioCookie"]["Usuario"];
            }

            if(Request.QueryString["men"]!=null &&
                Request.QueryString["men"].Equals("0")) {
                    LblMensaje.Text = ConstantesWeb.USUARIO_NO_SESION;
            } else {
                LblMensaje.Text = "";
            }
        }

        protected void BtnIniciar_Click(object sender, EventArgs e) {
            if(TxtUsuario.Text.Equals("categoria") &&
                TxtClave.Text.Equals("categoria")) 
            {
                //Usuario valido y crear la sesión
                UsersDto UsersDto = new UsersDto();
                UsersDto.Name = "Henry Joe";
                UsersDto.LastName = "Wong Urquiza";
                Session.Clear();
                //Agregando un usuario a la sesión
                Session.Add(ConstantesWeb.SESION_USUARIOINICIO, UsersDto);
                //Agregar una cookie
                HttpCookie UsuarioCookie = new HttpCookie("UsuarioCookie");
                UsuarioCookie["Usuario"] = TxtUsuario.Text;
                UsuarioCookie["Clave"] = TxtClave.Text;
                UsuarioCookie.Expires = DateTime.Now.AddDays(1d);
                //Enviar la cookie
                Response.Cookies.Add(UsuarioCookie);
                //Redireccionar
                Response.Redirect("Pages/Categoria/MntCategoria.aspx");
            } else {
                LblMensaje.Text = ConstantesWeb.USUARIO_CLAVE_INVALIDA;
            }
            
        }
    }
}