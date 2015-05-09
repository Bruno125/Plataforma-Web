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

namespace NorthwindDao.Dao
{
    public class CategoriesDao : Conexion,BaseDao<Categories,int>
    {

        public void Insertar(Categories Entity)
        {
            try
            {
                //1. Obtener la conexion
                SqlCon = ObtenerConexion();
                SqlCon.Open();
                //2. Establecer el comando
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "INSERT INTO Categories(CategoryName,Description)" +
                    "VALUES(@CategoryName,@Description)";
                SqlCmd.CommandType = CommandType.Text;
                //3. Establecer los parametros del comando
                SqlParameter SqlParamName = new SqlParameter();
                SqlParamName.ParameterName = "@CategoryName";
                SqlParamName.SqlDbType = SqlDbType.NVarChar;
                SqlParamName.Size = 15;
                SqlParamName.Value = Entity.CategoryName;

                SqlCmd.Parameters.Add(SqlParamName);

                SqlParameter SqlParamDesc = new SqlParameter();
                SqlParamDesc.ParameterName = "@Description";
                SqlParamDesc.SqlDbType = SqlDbType.NText;
                SqlParamDesc.Size = 16;
                SqlParamDesc.Value = Entity.Description;

                SqlParameter SqlParamCategoryId = new SqlParameter();
                SqlParamCategoryId.ParameterName = "@CategoryId";
                SqlParamCategoryId.SqlDbType = SqlDbType.Int;
                SqlParamCategoryId.Direction = ParameterDirection.InputOutput;
                SqlParamCategoryId.Value = 0;
                SqlCmd.Parameters.Add(SqlParamCategoryId);

                SqlCmd.Parameters.Add(SqlParamDesc);
                SqlCmd.ExecuteNonQuery();
                Entity.CategoryId = Convert.ToInt32(SqlCmd.Parameters["@CategoryId"].Value);
            }
            catch (Exception E)
            {
                throw new NorthwindException("Categories Dao - Insertar: " + E.Message,E);
            }
            finally
            {
                if (SqlCon != null && SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
        }
        public void Actualizar(Categories Entity)
        {
            try
            {
                SqlCon = ObtenerConexion();
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spU_Categories";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter SqlParamCategoryId = new SqlParameter();
                SqlParamCategoryId.ParameterName = "@CategoryId";
                SqlParamCategoryId.SqlDbType = SqlDbType.Int;
                SqlParamCategoryId.Value = Entity.CategoryId;
                SqlCmd.Parameters.Add(SqlParamCategoryId);

                SqlParameter SqlParamName = new SqlParameter();
                SqlParamName.ParameterName = "@CategoryName";
                SqlParamName.SqlDbType = SqlDbType.NVarChar;
                SqlParamName.Size = 15;
                SqlParamName.Value = Entity.CategoryName;
                SqlCmd.Parameters.Add(SqlParamName);

                SqlParameter SqlParamDesc = new SqlParameter();
                SqlParamDesc.ParameterName = "@Description";
                SqlParamDesc.SqlDbType = SqlDbType.NText;
                SqlParamDesc.Size = 16;
                SqlParamDesc.Value = Entity.Description;
                SqlCmd.Parameters.Add(SqlParamDesc);

                SqlCmd.ExecuteNonQuery();
                SqlCon.Close();
            }
            catch (Exception E)
            {
                throw new NorthwindException("Categories Dao - Actualizar: " + E.Message, E);
            }
            finally
            {
                if (SqlCon != null && SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
        }

        public void Eliminar(int id)
        {
            try{
                SqlCon = ObtenerConexion();
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.Text;
                SqlCmd.CommandText = "DELETE FROM Categories WHERE CategoryId = @CategoryId";

                SqlParameter SqlParamId = new SqlParameter();
                SqlParamId.ParameterName = "@CategoryId";
                SqlParamId.SqlDbType = SqlDbType.Int;
                SqlParamId.Value = id;

                SqlCmd.Parameters.Add(SqlParamId);
                SqlCmd.ExecuteNonQuery();
            }catch (Exception E)
            {
                throw new NorthwindException("Categories Dao - Eliminar: " + E.Message,E);
            }
            finally
            {
                if (SqlCon != null && SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }

        }

        public Categories Obtener(int id)
        {
            try
            {
                SqlCon = ObtenerConexion();
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.Text;
                SqlCmd.CommandText = "SELECT * FROM Categories WHERE CategoryId = @CategoryId";

                SqlParameter SqlParameterId = new SqlParameter();
                SqlParameterId.ParameterName = "@CategoryId";
                SqlParameterId.SqlDbType = SqlDbType.Int;
                SqlParameterId.Value = id;
                SqlCmd.Parameters.Add(SqlParameterId);

                DataTable DtCategories = new DataTable();
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtCategories);
                Categories Entity = new Categories();
                foreach (DataRow Row in DtCategories.Rows)
                {
                    Entity.CategoryId = Int32.Parse(Row["CategoryId"].ToString());
                    Entity.CategoryName = Row["CategoryName"].ToString();
                    Entity.Description = Row["Description"].ToString();
                }
                return Entity;
            }
            catch (Exception E)
            {
                throw new NorthwindException("Categories Dao - Obtener: " + E.Message,E);
            }
            finally
            {
                if (SqlCon != null && SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }

        }

        public System.Data.DataTable Listar() //Ejemplo de ADO desconectado: el adaptador es el que abre y cierra la conexion
        {
            DataTable DtCategories = new DataTable("Categories");
            SqlCon = ObtenerConexion();
            SqlCmd = new SqlCommand();
            SqlCmd.Connection = SqlCon;
            SqlCmd.CommandType = CommandType.Text;
            SqlCmd.CommandText = "SELECT * FROM Categories ORDER BY CategoryId";
            SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            SqlDat.Fill(DtCategories);
            return DtCategories;
        }

        #region Sentencias LinQ

        public List<string> ListarPorNombre(string Nombre)
        {
            List<string> ListaNombre = new List<string>();
            try
            {
                DataTable DtCategories = this.Listar();
                //var NombreCategorias = from fila in DtCategories.AsEnumerable()
                //                       where fila.Field<string>("CategoryName").ToLower().Contains(Nombre.ToLower())
                //                       orderby fila.Field<string>("CategoryName").ToLower() descending
                //                       select fila.Field<string>("CategoryName").ToLower();
                var NombreCategorias = DtCategories.AsEnumerable().
                    Where(fila => fila.Field<string>("CategoryName").ToLower().Contains(Nombre.ToLower())).
                    OrderBy(fila => fila.Field<string>("CategoryName")).
                    Select(fila => fila.Field<string>("CategoryName"));
                ListaNombre = NombreCategorias.ToList();
            }catch(Exception E)
            {
                throw new NorthwindException("Categories Dao - ListarPorNombre: " + E.Message,E);
            }
            return ListaNombre;
        }

        public List<Categories> ListarPorNombreObject(string Nombre)
        {
            List<Categories> ListaCategories = new List<Categories>();
            try
            {
                DataTable DtCategories = this.Listar();
                //var Categorias = from fila in DtCategories.AsEnumerable()
                //                       where fila.Field<string>("CategoryName").ToLower().Contains(Nombre.ToLower())
                //                       orderby fila.Field<string>("CategoryName").ToLower() descending
                //                       select new Categories
                //                       {
                //                           CategoryId = fila.Field<int>("CategoryId"),
                //                           CategoryName = fila.Field<string>("CategoryName"),
                //                           Description = (fila.Field<string>("Description")!=null)?fila.Field<string>("Description"):""
                //                       };
                //ListaCategories = Categorias.ToList();

                var Categorias = DtCategories.AsEnumerable()
                    .Where(fila => fila.Field<string>("CategoryName").ToLower().Contains(Nombre.ToLower())).
                    OrderBy(fila => fila.Field<string>("CategoryName").ToLower()).
                    Select(fila => new Categories
                    {
                        CategoryId = fila.Field<int>("CategoryId"),
                        CategoryName = fila.Field<string>("CategoryName"),
                        Description = fila.Field<string>("Description")//(fila.Field<string>("Description") != null) ? fila.Field<string>("Description") : ""
                    });
                ListaCategories = Categorias.ToList();
                return ListaCategories;
            }
            catch(Exception E)
            {
                throw new NorthwindException("Categories Dao - ListarPorNombreObject: " + E.Message, E);
            }
        }

        #endregion

    }
}
