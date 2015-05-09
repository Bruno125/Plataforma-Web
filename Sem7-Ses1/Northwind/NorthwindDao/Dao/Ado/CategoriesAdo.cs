using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importaciones de datos
using System.Data;
using System.Data.SqlClient;
using NorthwindDao.Base;
using NorthwindEntity.Entity;
using NorthwindUtil.ExceptionPer;

namespace NorthwindDao.Dao.Ado
{
    public sealed class CategoriesAdo : Conexion, ICategoriesDao
    {
        #region Bloque Singleton

        private static CategoriesAdo CATEGORIES_ADO = new CategoriesAdo();

        private CategoriesAdo()
        {

        }

        public static CategoriesAdo ObtenerInstancia()
        {
            return CATEGORIES_ADO;
        }

        #endregion

        public void Insertar(CategoriesDto Entity) 
        {
            try
            {
                SqlCon = ObtenerConexion();
                SqlCon.Open();
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "INSERT INTO Categories " +
                    "(CategoryName,Description) " +
                    "VALUES (@CategoryName,@Description); " +
                    "SET @CategoryID=SCOPE_IDENTITY()";
                SqlCmd.CommandType = CommandType.Text;
                
                SqlParameter SqlParamName = new SqlParameter();
                SqlParamName.ParameterName = "@CategoryName";
                SqlParamName.SqlDbType = SqlDbType.NVarChar;
                SqlParamName.Size = 15;
                SqlParamName.Value = Entity.CategoryName;
                SqlCmd.Parameters.Add(SqlParamName);

                SqlParameter SqlParamDescription = new SqlParameter();
                SqlParamDescription.ParameterName = "@Description";
                SqlParamDescription.SqlDbType = SqlDbType.NText;
                SqlParamDescription.Value = Entity.Description;
                SqlCmd.Parameters.Add(SqlParamDescription);

                SqlParameter SqlParamCategoryId = new SqlParameter();
                SqlParamCategoryId.ParameterName = "@CategoryID";
                SqlParamCategoryId.SqlDbType = SqlDbType.Int;
                SqlParamCategoryId.Direction = ParameterDirection.InputOutput;
                SqlParamCategoryId.Value = 0;
                SqlCmd.Parameters.Add(SqlParamCategoryId);

                SqlCmd.ExecuteNonQuery();

                Entity.CategoryID = Convert.ToInt32(
                    SqlCmd.Parameters["@CategoryID"].Value);
            }
            catch (Exception E)
            {
                throw new NothwindException("Categories Dao - Insertar: " +
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

        public void Actualizar(CategoriesDto Entity)
        {
            try
            {
                SqlCon = ObtenerConexion();
                SqlCon.Open();
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spU_Categories";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter SqlParamCategoryId = new SqlParameter();
                SqlParamCategoryId.ParameterName = "@CategoryID";
                SqlParamCategoryId.SqlDbType = SqlDbType.Int;
                SqlParamCategoryId.Value = Entity.CategoryID;
                SqlCmd.Parameters.Add(SqlParamCategoryId);

                SqlParameter SqlParamName = new SqlParameter();
                SqlParamName.ParameterName = "@CategoryName";
                SqlParamName.SqlDbType = SqlDbType.NVarChar;
                SqlParamName.Size = 15;
                SqlParamName.Value = Entity.CategoryName;
                SqlCmd.Parameters.Add(SqlParamName);

                SqlParameter SqlParamDescription = new SqlParameter();
                SqlParamDescription.ParameterName = "@Description";
                SqlParamDescription.SqlDbType = SqlDbType.NText;
                SqlParamDescription.Value = Entity.Description;
                SqlCmd.Parameters.Add(SqlParamDescription);

                SqlCmd.ExecuteNonQuery();
                
            }
            catch (Exception E)
            {
                throw new NothwindException("Categories Dao - Actualizar: " +
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
                SqlCmd.CommandText = "DELETE FROM Categories WHERE CategoryID=@CategoryID";
                SqlCmd.CommandType = CommandType.Text;
                SqlParameter SqlParamCategoryId = new SqlParameter();
                SqlParamCategoryId.ParameterName = "@CategoryID";
                SqlParamCategoryId.SqlDbType = SqlDbType.Int;
                SqlParamCategoryId.Value = Id;
                SqlCmd.Parameters.Add(SqlParamCategoryId);
                SqlCmd.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                throw new NothwindException("Categories Dao - Eliminar: " +
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

        public CategoriesDto Obtener(int Id)
        {
            CategoriesDto Entity = new CategoriesDto();
            try
            {
                DataTable DtCategories = new DataTable("Categories");
                //1. Obtener Conexion
                SqlCon = ObtenerConexion();
                //2. Establecer el comando
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SELECT * FROM Categories WHERE " +
                    "CategoryID = @CategoryID";
                SqlCmd.CommandType = CommandType.Text;
                SqlParameter SqlParamCategoryId = new SqlParameter();
                SqlParamCategoryId.ParameterName = "@CategoryID";
                SqlParamCategoryId.SqlDbType = SqlDbType.Int;
                SqlParamCategoryId.Value = Id;
                SqlCmd.Parameters.Add(SqlParamCategoryId);
                //3. Llenar el Datatable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtCategories);
                //4. Llenado el objeto categoria
                foreach (DataRow fila in DtCategories.Rows)
                {
                    Entity.CategoryID = Int32.Parse(fila["CategoryID"].ToString());
                    Entity.CategoryName = fila["CategoryName"].ToString();
                    Entity.Description = fila["Description"].ToString();
                }
            }
            catch (Exception E)
            {
                throw new NothwindException("Categories Dao - Obtener: " +
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

        public List<CategoriesDto> Listar()
        {
            List<CategoriesDto> ListaCategoriesDto = new List<CategoriesDto>();
            DataTable DtCategories = new DataTable("Categories");
            try
            {
                SqlCon = ObtenerConexion();
                SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "SELECT * FROM Categories ORDER BY CategoryName";
                SqlCmd.CommandType = CommandType.Text;
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtCategories);
                foreach (DataRow fila in DtCategories.Rows)
                {
                    CategoriesDto CategoriesDto = new CategoriesDto();
                    CategoriesDto.CategoryID = Int32.Parse(fila["CategoryID"].ToString());
                    CategoriesDto.CategoryName = fila["CategoryName"].ToString().ToUpper();
                    CategoriesDto.Description = fila["Description"].ToString().ToUpper();
                    ListaCategoriesDto.Add(CategoriesDto);
                }
            }
            catch (Exception E)
            {
                throw new NothwindException("Categories Dao - Listar: " +
                    E.Message, E);
            }
            finally
            {
                if (SqlCon != null && SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }

            return ListaCategoriesDto;
        }


        #region Sentencias LinQ

        public List<string> ListarPorNombre(string Nombre)
        {
            List<string> ListaNombre = new List<string>();
            try
            {
                List<CategoriesDto> ListaCategoriesDto = this.Listar();
                var NombreCategorias = ListaCategoriesDto.
                                        Where(fila => fila.CategoryName.ToUpper().Contains(Nombre.ToUpper())).
                                        OrderBy(fila => fila.CategoryName.ToUpper()).
                                        Select(fila => fila.CategoryName.ToUpper());
                ListaNombre = NombreCategorias.ToList();
            }
            catch (Exception E)
            {
                throw new NothwindException("Categories Dao - ListarPorNombre: " +
                   E.Message, E);
            }
            return ListaNombre;
        }


        public List<CategoriesDto> ListarPorNombreObjeto(string Nombre)
        {
            List<CategoriesDto> ListaCategoriesResultado = new List<CategoriesDto>();
            try
            {
                List<CategoriesDto> ListaCategoriesDto = this.Listar();
                var Categorias =
                    ListaCategoriesDto.AsEnumerable().
                    Where(fila => fila.CategoryName.ToUpper().Contains(Nombre.ToUpper())).
                    OrderBy(fila => fila.CategoryName.ToUpper()).
                    Select(fila => new CategoriesDto 
                    {
                        CategoryID = fila.CategoryID,
                        CategoryName = fila.CategoryName.ToUpper(),
                        Description = fila.Description
                    });
                ListaCategoriesResultado = Categorias.ToList();
            }
            catch (Exception E)
            {
                throw new NothwindException("Categories Dao - ListarPorNombreObjeto: " +
                   E.Message, E);
            }
            return ListaCategoriesResultado;
        }

        #endregion
    }
}
