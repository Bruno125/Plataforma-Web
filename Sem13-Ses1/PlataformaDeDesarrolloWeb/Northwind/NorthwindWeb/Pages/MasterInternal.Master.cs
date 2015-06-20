using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//importaciones
using NorthwindWeb.Util;
namespace NorthwindWeb.Pages {
    public partial class MasterInternal : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
            if(Session == null ||
                Session[ConstantesWeb.SESION_USUARIOINICIO] == null) {
                    Response.Redirect("~/Index.aspx?men=0");
            }
        }
    }
}