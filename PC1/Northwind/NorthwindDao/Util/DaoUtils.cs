using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDao.Util
{
    public sealed class DaoUtils
    {
        private static DaoUtils DAO_UTILS = new DaoUtils();
        private DaoUtils() { }
        public static DaoUtils ObtenerInstancia()
        {
            return DAO_UTILS;
        }

        public SqlParameter ObtenerParameter(string ParamName, SqlDbType Type, object Value, int Size)
        {
            SqlParameter SqlParamName = new SqlParameter();
            SqlParamName.ParameterName = ParamName;
            SqlParamName.SqlDbType = Type;
            if(Size!=-1)    
                SqlParamName.Size = Size;
            SqlParamName.Value = Value;
            return SqlParamName;
        }

    }
}
