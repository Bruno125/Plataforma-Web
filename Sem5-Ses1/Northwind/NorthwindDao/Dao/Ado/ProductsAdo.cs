using NorthwindDao.Base;
using NorthwindEntity.Entity;
using NorthwindUtil.ExceptionPer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDao.Dao.Ado
{
    public sealed class ProductsAdo : Conexion, IProductsDao
    {
        #region
        private static ProductsAdo PRODUCTS_ADO = new ProductsAdo();
        private ProductsAdo() { }

        public static ProductsAdo ObtenerInstancia()
        {
            return PRODUCTS_ADO;
        }

        #endregion


        public void Insertar(Products Entity)
        {
        }

        public void Actualizar(Products Entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int Id)
        {
            throw new NotImplementedException();
        }

        public Products Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public DataTable Listar()
        {
            DataTable DtProducts = new DataTable("Products");
            try
            {
                SqlCon = ObtenerConexion();
                SqlCon.Open();
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.Text;
                SqlCmd.CommandText = "SELECT * FROM Products ORDER BY ProductID";

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtProducts);
            }
            catch (Exception E)
            {
                throw new NorthwindException("NorthwindDao - Insertar producto: " + E.Message);
            }
            finally
            {
                if(SqlCon!=null && SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
            return DtProducts;
        }
    }
}
