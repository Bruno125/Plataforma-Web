using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindWeb {
    public partial class Error : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
            Exception Exception = Server.GetLastError();
            if (Exception != null) 
            {
                String mensaje = "Ocurrrio un error en el sistema";
                if (Exception.InnerException != null) 
                {
                    LblTraceInterno.Text = 
                        Exception.InnerException.StackTrace;
                    
                    InnerErrorPanel.Visible = Request.IsLocal;
                    
                    LblErrorInterno.Text = 
                        Exception.InnerException.Message;
                }

                if (Request.IsLocal) 
                {
                    LblErrorTrace.Visible = true;
                } else 
                {
                    Exception = new Exception(mensaje, Exception);
                }
                LblErrorMensaje.Text = Exception.Message;
                LblErrorTrace.Text = Exception.StackTrace;
                NorthwindWeb.Util.UtilWeb.LogException(Exception, "Error ");
            }
            Server.ClearError();
        }
    }
}