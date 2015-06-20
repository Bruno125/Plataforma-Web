using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindWeb {
    public partial class MasterExternal : System.Web.UI.MasterPage {
        protected void Page_Load(object sender, EventArgs e) {
            //Cuando voy a ir a la pagina de inicio y al de error
            if (Session != null) 
            {
                //Elimina todas las variables de la sesión
                Session.Clear();
            }
        }
    }
}