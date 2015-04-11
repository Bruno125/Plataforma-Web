using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NorthWindDAO.Base
{
    public class Conexion
    {
        protected SqlConnection SqlCon;
        protected SqlCommand SqlCmd;


        protected SqlConnection ObtenerConexion()
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon.ConnectionString = "Data Source=.;Initial Catalog=NORTHWND;Integrated Security=True";
            return SqlCon;
        }
    }
}
