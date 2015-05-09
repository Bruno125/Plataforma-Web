using NorthwindDao.Base;
using NorthwindDao.Util;
using NorthwindEntity.Entity;
using NorthwindUtil.ExceptionPer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDao.Dao
{
    public class ProductDao : Conexion, BaseDao<Products,int>
    {
        public void Insertar(Products Entity)
        {
            try
            {
                SqlCon = ObtenerConexion();
                SqlCon.Open();
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "INSERT INTO Products"+
                    "(ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued) " +
                    "VALUES (@ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@UnitsInStock,@UnitsOnOrder,@ReorderLevel,@Discontinued)";
                SqlCmd.CommandType = CommandType.Text;
                DaoUtils DaoUtils = DaoUtils.ObtenerInstancia();
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@ProductName", SqlDbType.NVarChar, Entity.ProductName, 40));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@SupplierID", SqlDbType.Int, Entity.SupplierId, -1));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@CategoryID", SqlDbType.Int, Entity.CategoryId, -1));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@QuantityPerUnit", SqlDbType.NVarChar, Entity.QuantityPerUnit, 20));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@UnitPrice", SqlDbType.Money, Entity.UnitPrice, -1));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@UnitsInStock", SqlDbType.Int, Entity.UnitsInStock, -1));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@UnitsOnOrder", SqlDbType.Int, Entity.UnitsOnOrder, -1));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@ReorderLevel", SqlDbType.Int, Entity.ReorderLevel, -1));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@Discontinued", SqlDbType.Bit, Entity.Discontinued, -1));

                SqlParameter SqlParamProductId = new SqlParameter();
                SqlParamProductId.ParameterName = "@ProductId";
                SqlParamProductId.SqlDbType = SqlDbType.Int;
                SqlParamProductId.Direction = ParameterDirection.InputOutput;
                SqlParamProductId.Value = 0;
                SqlCmd.Parameters.Add(SqlParamProductId);

                SqlCmd.ExecuteNonQuery();
                Entity.ProductId = Convert.ToInt32(SqlCmd.Parameters["@ProductId"].Value);
            }
            catch (Exception E)
            {
                throw new NorthwindException("ProductDao Insertar: " + E.Message, E);
            }
            finally
            {
                if (SqlCon != null && SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
        }

        public void Actualizar(Products Entity)
        {
            try
            {
                SqlCon = ObtenerConexion();
                SqlCon.Open();
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.Text;
                SqlCmd.CommandText = "UPDATE Products SET " +
                    "ProductName = @ProductName," +
                    "SupplierID = @SupplierID," +
                    "QuantityPerUnit = @QuantityPerUnit," +
                    "UnitPrice = @UnitPrice," +
                    "UnitsInStock = @UnitsInStock," +
                    "UnitsOnOrder = @UnitsOnOrder," +
                    "ReorderLevel = @ReorderLevel," +
                    "Discontinued = @Discontinued," +
                    "CategoryID = @CategoryID " +
                    "WHERE ProductID = @ProductID";
                DaoUtils DaoUtils = DaoUtils.ObtenerInstancia();

                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@ProductID", SqlDbType.Int, Entity.ProductId, -1));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@ProductName", SqlDbType.NVarChar, Entity.ProductName, 40));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@SupplierID", SqlDbType.Int, 1, -1));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@QuantityPerUnit", SqlDbType.NVarChar, Entity.QuantityPerUnit, 20));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@UnitPrice", SqlDbType.Money, Entity.UnitPrice, -1));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@UnitsInStock", SqlDbType.Int, Entity.UnitsInStock, -1));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@UnitsOnOrder", SqlDbType.Int, Entity.UnitsOnOrder, -1));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@ReorderLevel", SqlDbType.Int, Entity.ReorderLevel, -1));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@Discontinued", SqlDbType.Bit, Entity.Discontinued, -1));
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@CategoryID", SqlDbType.Int, Entity.CategoryId, -1));
                SqlCmd.ExecuteNonQuery();


            }
            catch (Exception E)
            {
                throw new NorthwindException("ProductDao Actualizar: " + E.Message, E);
            }
            finally
            {
                if (SqlCon != null && SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
        }

        public void Eliminar(int Id)
        {
            try
            {
                SqlCon = ObtenerConexion();
                SqlCon.Open();
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.Text;
                SqlCmd.CommandText = "DELETE FROM Products WHERE ProductID=@ProductID";
                DaoUtils DaoUtils = DaoUtils.ObtenerInstancia();
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@ProductID",SqlDbType.Int,Id,-1));

                SqlCmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                throw new NorthwindException("ProductDao Eliminar: " + E.Message, E);
            }
            finally
            {
                if (SqlCon != null && SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
        }

        public Products Obtener(int id)
        {
            try
            {
                SqlCon = ObtenerConexion();
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.Text;
                SqlCmd.CommandText = "SELECT * FROM Products WHERE ProductID=@ProductID";
                DaoUtils DaoUtils = DaoUtils.ObtenerInstancia();
                SqlCmd.Parameters.Add(DaoUtils.ObtenerParameter("@ProductID", SqlDbType.Int, id, -1));
                DataTable DtProducts = new DataTable();
                SqlDataAdapter DataAdapter = new SqlDataAdapter(SqlCmd);
                DataAdapter.Fill(DtProducts);

                Products Entity = new Products();
                foreach (DataRow Row in DtProducts.Rows)
                {
                    Entity.ProductId = Int32.Parse(Row["ProductID"].ToString());
                    Entity.ProductName = Row["ProductName"].ToString();
                    Entity.SupplierId = Int32.Parse(Row["SupplierID"].ToString());
                    Entity.CategoryId = Int32.Parse(Row["CategoryId"].ToString());
                    Entity.QuantityPerUnit = Row["QuantityPerUnit"].ToString();
                    Entity.UnitPrice = Decimal.Parse(Row["UnitPrice"].ToString());
                    Entity.UnitsInStock = Int32.Parse(Row["UnitsInStock"].ToString());
                    Entity.UnitsOnOrder = Int32.Parse(Row["UnitsOnOrder"].ToString());
                    Entity.ReorderLevel = Int32.Parse(Row["CategoryId"].ToString());
                    Entity.Discontinued = Boolean.Parse(Row["Discontinued"].ToString());
                }
                return Entity;
            }
            catch (Exception E)
            {
                throw new NorthwindException("ProductDao Eliminar: " + E.Message, E);
            }
            finally
            {
                if (SqlCon != null && SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
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

        public List<Products> ListarPorObjetoProducts()
        {
            List<Products> ListaProductos = new List<Products>();
            try
            {
                DataTable DtProductos = this.Listar();
                var Productos = from fila in DtProductos.AsEnumerable()
                                 select new Products
                                 {
                                     ProductId = fila.Field<int>("ProductId"),
                                     ProductName = fila.Field<string>("ProductName")
                                 };
                ListaProductos = Productos.ToList();
                return ListaProductos;
            }
            catch (Exception E)
            {
                throw new NorthwindException("Categories Dao - ListarPorNombreObject: " + E.Message, E);
            }
        }

    }

}
