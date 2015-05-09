using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importaciones de base de datos
using System.Data;
using System.Data.SqlClient;

namespace NorthwindDao.Base
{
    public class Conexion
    {
        protected SqlConnection SqlCon;
        protected SqlCommand SqlCmd;

        protected SqlConnection ObtenerConexion()
        {
            SqlConnection SqlConTemp = new SqlConnection();
            SqlConTemp.ConnectionString = "Data Source=PSDYM1003;Initial Catalog=NORTHWND;" +
                "Initial Catalog=NORTHWND;User ID=sa;Password=Clave12345678";
            return SqlConTemp;
        }
    }
}
