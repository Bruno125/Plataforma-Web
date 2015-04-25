using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindUtil.ExceptionPer;
using NorthwindEntity.Entity;
using NorthwindDao.Dao;
using NorthwindBussiness.Base;
using System.Data;
using NorthwindBussiness.Util;
namespace NorthwindBussiness.Business
{
    public sealed class CategoriesBusiness : BaseBusiness<Categories, int>
    {
        #region Singleton

        private static CategoriesBusiness CATEGORIES_BUSINESS = new CategoriesBusiness();
        private CategoriesBusiness() { }
        public static CategoriesBusiness ObtenerInstancia()
        {
            return CATEGORIES_BUSINESS;
        }
        #endregion

        private ICategoriesDao CategoriesDao = UtilBusiness.ObtenerInstancia(UtilBusiness.Clase.Categories) as ICategoriesDao;

        public void Insertar(Categories Entity)
        {
            try
            {
                CategoriesDao.Insertar(Entity);
            }
            catch(Exception E)
            {
                throw new NorthwindException("CategoriesBusiness - Insertar: " + E.Message, E);
            }
        }

        public void Actualizar(Categories Entity)
        {
            try
            {
                CategoriesDao.Actualizar(Entity);
            }
            catch (Exception E)
            {
                throw new NorthwindException("CategoriesBusiness - Actualizar: " + E.Message, E);
            }
        }

        public void Eliminar(int Id)
        {
            try
            {
                CategoriesDao.Eliminar(Id);
            }
            catch (Exception E)
            {
                throw new NorthwindException("CategoriesBusiness - Eliminar: " + E.Message, E);
            }
        }

        public Categories Obtener(int id)
        {
            try
            {
                return CategoriesDao.Obtener(id);
            }
            catch (Exception E)
            {
                throw new NorthwindException("CategoriesBusiness - Obtener: " + E.Message, E);
            }
        }

        public DataTable Listar()
        {
            try
            {
                return CategoriesDao.Listar();
            }
            catch (Exception E)
            {
                throw new NorthwindException("CategoriesBusiness - Listar: " + E.Message, E);
            }
        }

        public List<string> ListarPorNombre(string Nombre)
        {
            try
            {
                return CategoriesDao.ListarPorNombre(Nombre);
            }
            catch (Exception E)
            {
                throw new NorthwindException("CategoriesBusiness - ListarPorNombre: " + E.Message, E);
            }
        }

        public List<Categories> ListarObjetoPorNombre(string Nombre)
        {
            try
            {
                return CategoriesDao.ListarPorNombreObject(Nombre);
            }
            catch (Exception E)
            {
                throw new NorthwindException("CategoriesBusiness - ListarObjetoPorNombre: " + E.Message, E);
            }
        }
    }
}
