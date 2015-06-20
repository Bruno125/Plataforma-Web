using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importaciones
using NorthwindDao.Base;
using NorthwindEntity.Entity;
using NorthwindUtil.ExceptionPer;
using System.Data;
using System.Data.SqlClient;

namespace NorthwindDao.Dao.Ado
{
    /**
     * sealed class : No permite la sobreescritura de metodos
     * */
    public sealed class ProductsAdo : Conexion, IProductsDao
    {
        #region Patron Singleton
        private static ProductsAdo PRODUCTS_ADO = new ProductsAdo();
        private ProductsAdo()
        {

        }
        public static ProductsAdo ObtenerInstancia()
        {
            return PRODUCTS_ADO;
        }
        #endregion


        public void Insertar(ProductsDto Entity)
        {
            try
            {
                SqlCon = ObtenerConexion();
                SqlCon.Open();
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "INSERT INTO Products " +
                   "(ProductName " +
                   ",SupplierID " +
                   ",CategoryID " +
                   ",QuantityPerUnit " +
                   ",UnitPrice " +
                   ",UnitsInStock  " +
                   ",UnitsOnOrder  " +
                   ",ReorderLevel  " +
                   ",Discontinued) VALUES " +
                   "(@ProductName " +
                   ",@SupplierID " +
                   ",@CategoryID " +
                   ",@QuantityPerUnit " +
                   ",@UnitPrice " +
                   ",@UnitsInStock " +
                   ",@UnitsOnOrder " +
                   ",@ReorderLevel " +
                   ",@Discontinued); " +
                    "SET @ProductID=SCOPE_IDENTITY()";
                SqlCmd.CommandType = CommandType.Text;
                
                SqlParameter SqlParamName = new SqlParameter();
                SqlParamName.ParameterName = "@ProductName";
                SqlParamName.SqlDbType = SqlDbType.NVarChar;
                SqlParamName.Size = 40;
                SqlParamName.Value = Entity.ProductName;
                SqlCmd.Parameters.Add(SqlParamName);

                SqlParameter SqlParamSupplierID = new SqlParameter();
                SqlParamSupplierID.ParameterName = "@SupplierID";
                SqlParamSupplierID.SqlDbType = SqlDbType.Int;
                SqlParamSupplierID.Value = Entity.SupplierID;
                SqlCmd.Parameters.Add(SqlParamSupplierID);


                SqlParameter SqlParamCategoryID = new SqlParameter();
                SqlParamCategoryID.ParameterName = "@CategoryID";
                SqlParamCategoryID.SqlDbType = SqlDbType.Int;
                SqlParamCategoryID.Value = Entity.CategoryID;
                SqlCmd.Parameters.Add(SqlParamCategoryID);

                SqlParameter SqlParamQuantityPerUnit = new SqlParameter();
                SqlParamQuantityPerUnit.ParameterName = "@QuantityPerUnit";
                SqlParamQuantityPerUnit.SqlDbType = SqlDbType.NVarChar;
                SqlParamQuantityPerUnit.Size = 20;
                SqlParamQuantityPerUnit.Value = Entity.QuantityPerUnit;
                SqlCmd.Parameters.Add(SqlParamQuantityPerUnit);

                SqlParameter SqlParamUnitPrice = new SqlParameter();
                SqlParamUnitPrice.ParameterName = "@UnitPrice";
                SqlParamUnitPrice.SqlDbType = SqlDbType.Money;
                SqlParamUnitPrice.Value = Entity.UnitPrice;
                SqlCmd.Parameters.Add(SqlParamUnitPrice);

                SqlParameter SqlParamUnitsInStock = new SqlParameter();
                SqlParamUnitsInStock.ParameterName = "@UnitsInStock";
                SqlParamUnitsInStock.SqlDbType = SqlDbType.SmallInt;
                SqlParamUnitsInStock.Value = Entity.UnitsInStock;
                SqlCmd.Parameters.Add(SqlParamUnitsInStock);

                SqlParameter SqlParamUnitsOnOrder = new SqlParameter();
                SqlParamUnitsOnOrder.ParameterName = "@UnitsOnOrder";
                SqlParamUnitsOnOrder.SqlDbType = SqlDbType.SmallInt;
                SqlParamUnitsOnOrder.Value = Entity.UnitsOnOrder;
                SqlCmd.Parameters.Add(SqlParamUnitsOnOrder);

                SqlParameter SqlParamReorderLevel = new SqlParameter();
                SqlParamReorderLevel.ParameterName = "@ReorderLevel";
                SqlParamReorderLevel.SqlDbType = SqlDbType.SmallInt;
                SqlParamReorderLevel.Value = Entity.ReorderLevel;
                SqlCmd.Parameters.Add(SqlParamReorderLevel);

                SqlParameter SqlParamDiscontinued = new SqlParameter();
                SqlParamDiscontinued.ParameterName = "@Discontinued";
                SqlParamDiscontinued.SqlDbType = SqlDbType.Bit;
                SqlParamDiscontinued.Value = Entity.Discontinued;
                SqlCmd.Parameters.Add(SqlParamDiscontinued);

                SqlParameter SqlParamProductID = new SqlParameter();
                SqlParamProductID.ParameterName = "@ProductID";
                SqlParamProductID.SqlDbType = SqlDbType.Int;
                SqlParamProductID.Direction = ParameterDirection.InputOutput;
                SqlParamProductID.Value = 0;
                SqlCmd.Parameters.Add(SqlParamProductID);

                SqlCmd.ExecuteNonQuery();

                Entity.ProductID = Convert.ToInt32(
                    SqlCmd.Parameters["@ProductID"].Value);
            }
            catch (Exception E)
            {
                throw new NothwindException("Products Dao - Insertar: " +
                    E.Message, E);
            }
            finally
            {
                if (SqlCon != null && SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }

        public void Actualizar(ProductsDto Entity)
        {
            try
            {
                SqlCon = ObtenerConexion();
                SqlCon.Open();
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "UPDATE Products " +
                "SET ProductName = @ProductName, " +
                "SupplierID = @SupplierID,  " +
                "CategoryID = @CategoryID,  " +
                "QuantityPerUnit = @QuantityPerUnit,  " +
                "UnitPrice = @UnitPrice,  " +
                "UnitsInStock = @UnitsInStock,  " +
                "UnitsOnOrder = @UnitsOnOrder,  " +
                "ReorderLevel = @ReorderLevel,  " +
                "Discontinued = @Discontinued  " +
                "WHERE  " +
	            "ProductID = @ProductID";
                SqlCmd.CommandType = CommandType.Text;

                SqlParameter SqlParamName = new SqlParameter();
                SqlParamName.ParameterName = "@ProductName";
                SqlParamName.SqlDbType = SqlDbType.NVarChar;
                SqlParamName.Size = 40;
                SqlParamName.Value = Entity.ProductName;
                SqlCmd.Parameters.Add(SqlParamName);

                SqlParameter SqlParamSupplierID = new SqlParameter();
                SqlParamSupplierID.ParameterName = "@SupplierID";
                SqlParamSupplierID.SqlDbType = SqlDbType.Int;
                SqlParamSupplierID.Value = Entity.SupplierID;
                SqlCmd.Parameters.Add(SqlParamSupplierID);


                SqlParameter SqlParamCategoryID = new SqlParameter();
                SqlParamCategoryID.ParameterName = "@CategoryID";
                SqlParamCategoryID.SqlDbType = SqlDbType.Int;
                SqlParamCategoryID.Value = Entity.CategoryID;
                SqlCmd.Parameters.Add(SqlParamCategoryID);

                SqlParameter SqlParamQuantityPerUnit = new SqlParameter();
                SqlParamQuantityPerUnit.ParameterName = "@QuantityPerUnit";
                SqlParamQuantityPerUnit.SqlDbType = SqlDbType.NVarChar;
                SqlParamQuantityPerUnit.Size = 20;
                SqlParamQuantityPerUnit.Value = Entity.QuantityPerUnit;
                SqlCmd.Parameters.Add(SqlParamQuantityPerUnit);

                SqlParameter SqlParamUnitPrice = new SqlParameter();
                SqlParamUnitPrice.ParameterName = "@UnitPrice";
                SqlParamUnitPrice.SqlDbType = SqlDbType.Money;
                SqlParamUnitPrice.Value = Entity.UnitPrice;
                SqlCmd.Parameters.Add(SqlParamUnitPrice);

                SqlParameter SqlParamUnitsInStock = new SqlParameter();
                SqlParamUnitsInStock.ParameterName = "@UnitsInStock";
                SqlParamUnitsInStock.SqlDbType = SqlDbType.SmallInt;
                SqlParamUnitsInStock.Value = Entity.UnitsInStock;
                SqlCmd.Parameters.Add(SqlParamUnitsInStock);

                SqlParameter SqlParamUnitsOnOrder = new SqlParameter();
                SqlParamUnitsOnOrder.ParameterName = "@UnitsOnOrder";
                SqlParamUnitsOnOrder.SqlDbType = SqlDbType.SmallInt;
                SqlParamUnitsOnOrder.Value = Entity.UnitsOnOrder;
                SqlCmd.Parameters.Add(SqlParamUnitsOnOrder);

                SqlParameter SqlParamReorderLevel = new SqlParameter();
                SqlParamReorderLevel.ParameterName = "@ReorderLevel";
                SqlParamReorderLevel.SqlDbType = SqlDbType.SmallInt;
                SqlParamReorderLevel.Value = Entity.ReorderLevel;
                SqlCmd.Parameters.Add(SqlParamReorderLevel);

                SqlParameter SqlParamDiscontinued = new SqlParameter();
                SqlParamDiscontinued.ParameterName = "@Discontinued";
                SqlParamDiscontinued.SqlDbType = SqlDbType.Bit;
                SqlParamDiscontinued.Value = Entity.Discontinued;
                SqlCmd.Parameters.Add(SqlParamDiscontinued);

                SqlParameter SqlParamProductID = new SqlParameter();
                SqlParamProductID.ParameterName = "@ProductID";
                SqlParamProductID.SqlDbType = SqlDbType.Int;
                SqlParamProductID.Value = Entity.ProductID;
                SqlCmd.Parameters.Add(SqlParamProductID);

                SqlCmd.ExecuteNonQuery();

            }
            catch (Exception E)
            {
                throw new NothwindException("Products Dao - Actualizar: " +
                    E.Message, E);
            }
            finally
            {
                if (SqlCon != null && SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
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
                SqlCmd.CommandText = "DELETE FROM Products WHERE ProductID=@ProductID";
                SqlCmd.CommandType = CommandType.Text;
                SqlParameter SqlParamProductID = new SqlParameter();
                SqlParamProductID.ParameterName = "@ProductID";
                SqlParamProductID.SqlDbType = SqlDbType.Int;
                SqlParamProductID.Value = Id;
                SqlCmd.Parameters.Add(SqlParamProductID);
                SqlCmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                throw new NothwindException("Products Dao - Eliminar: " +
                    E.Message, E);
            }
            finally
            {
                if (SqlCon != null && SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }

        public ProductsDto Obtener(int Id)
        {
            ProductsDto Entity = new ProductsDto();
            try
            {
                DataTable DtProducts = new DataTable("Products");
                //1. Obtener Conexion
                SqlCon = ObtenerConexion();
                //2. Establecer el comando
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SELECT * FROM Products P inner join Categories C ON P.CategoryID = C.CategoryID WHERE " +
                    "ProductID = @ProductID ";
                SqlCmd.CommandType = CommandType.Text;
                SqlParameter SqlParamProductID = new SqlParameter();
                SqlParamProductID.ParameterName = "@ProductID";
                SqlParamProductID.SqlDbType = SqlDbType.Int;
                SqlParamProductID.Value = Id;
                SqlCmd.Parameters.Add(SqlParamProductID);
                //3. Llenar el Datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtProducts);
                //4. Llenado el objeto categoria
                foreach (DataRow fila in DtProducts.Rows)
                {
                    Entity.ProductID = Int32.Parse(fila["ProductID"].ToString());
                    Entity.ProductName = fila["ProductName"].ToString().ToUpper();
                    Entity.SupplierID = Int32.Parse(fila["SupplierID"].ToString());
                    Entity.CategoryID = Int32.Parse(fila["CategoryID"].ToString());
                    Entity.QuantityPerUnit = fila["QuantityPerUnit"].ToString();
                    Entity.UnitPrice = Decimal.Parse(fila["UnitPrice"].ToString());
                    Entity.UnitsInStock = Int32.Parse(fila["UnitsInStock"].ToString());
                    Entity.UnitsOnOrder = Int32.Parse(fila["UnitsOnOrder"].ToString());
                    Entity.ReorderLevel = Int32.Parse(fila["ReorderLevel"].ToString());
                    Entity.Discontinued = Boolean.Parse(fila["Discontinued"].ToString());
                }
            }
            catch (Exception E)
            {
                throw new NothwindException("Products Dao - Obtener: " +
                    E.Message, E);
            }
            finally
            {
                if (SqlCon != null && SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return Entity;
        }

        public List<ProductsDto> Listar()
        {
            DataTable DtProductos = new DataTable("Products");
            List<ProductsDto> ListaProducts = new List<ProductsDto>();
            try
            {
                SqlCon = ObtenerConexion();
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SELECT * FROM Products";
                SqlCmd.CommandType = CommandType.Text;
                SqlDataAdapter SqlDatAda = new SqlDataAdapter(SqlCmd);
                SqlDatAda.Fill(DtProductos);
                foreach (DataRow fila in DtProductos.Rows)
                {
                    ProductsDto ProductsDto = new ProductsDto();
                    ProductsDto.ProductID = Int32.Parse(fila["ProductID"].ToString());
                    ProductsDto.ProductName = fila["ProductName"].ToString().ToUpper();
                    ProductsDto.SupplierID = Int32.Parse(fila["SupplierID"].ToString());
                    ProductsDto.CategoryID = Int32.Parse(fila["CategoryID"].ToString());
                    ProductsDto.QuantityPerUnit = fila["QuantityPerUnit"].ToString();
                    ProductsDto.UnitPrice = Decimal.Parse(fila["UnitPrice"].ToString());
                    ProductsDto.UnitsInStock = Int32.Parse(fila["UnitsInStock"].ToString());
                    ProductsDto.UnitsOnOrder = Int32.Parse(fila["UnitsOnOrder"].ToString());
                    ProductsDto.ReorderLevel = Int32.Parse(fila["ReorderLevel"].ToString());
                    ProductsDto.Discontinued = Boolean.Parse(fila["Discontinued"].ToString());
                    ListaProducts.Add(ProductsDto);
                }
            }
            catch (Exception E)
            {

                throw new NothwindException("Products Dao - Listar: " + E.Message, E);
            }
            finally
            {
                if (SqlCon != null && SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return ListaProducts;
        }

    }
}
