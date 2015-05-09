using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importaciones de otros proyectos
using NorthwindUtil.ExceptionPer;
using NorthwindEntity.Entity;
using NorthwindDao.Dao;
using NorthwindBusiness.Base;
using NorthwindBusiness.Util;

namespace NorthwindBusiness.Business
{
    public sealed class CategoriesBusiness : BaseBusiness<CategoriesDto, int>
    {
        #region Patron Singleton
        private static CategoriesBusiness CATEGORIES_BUSINESS = new CategoriesBusiness();
        private CategoriesBusiness()
        {

        }

        public static CategoriesBusiness ObtenerInstancia()
        {
            return CATEGORIES_BUSINESS;
        }
        #endregion

        private ICategoriesDao CategoriesDao =
                    (ICategoriesDao)UtilBusiness.ObtenerInstancia(UtilBusiness.Clase.Categories);

        private IProductsDao ProductsDao =
            (IProductsDao)UtilBusiness.ObtenerInstancia(UtilBusiness.Clase.Products);

        public void Insertar(CategoriesDto Entity)
        {
            try
            {
                CategoriesDao.Insertar(Entity);
            }
            catch (Exception E)
            {
                throw new NothwindException("CategoriesBusiness - Insertar: " + 
                    E.Message , E);
            }
        }

        public void Actualizar(CategoriesDto Entity)
        {
            try
            {
                CategoriesDao.Actualizar(Entity);
            }
            catch (Exception E)
            {
                throw new NothwindException("CategoriesBusiness - Actualizar: " +
                    E.Message, E);
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
                throw new NothwindException("CategoriesBusiness - Eliminar: " +
                    E.Message, E);
            }
        }

        public CategoriesDto Obtener(int Id)
        {
            try
            {
                return CategoriesDao.Obtener(Id);
            }
            catch (Exception E)
            {
                throw new NothwindException("CategoriesBusiness - Obtener: " +
                    E.Message, E);
            }
        }

        public List<CategoriesDto> Listar()
        {
            try
            {
                return CategoriesDao.Listar();
            }
            catch (Exception E)
            {
                throw new NothwindException("CategoriesBusiness - Listar: " +
                    E.Message, E);
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
                throw new NothwindException("CategoriesBusiness - ListarPorNombre: " +
                    E.Message, E);
            }
        }

        public List<CategoriesDto> ListarPorNombreObjeto(string Nombre)
        {
            try
            {
                return CategoriesDao.ListarPorNombreObjeto(Nombre);
            }
            catch (Exception E)
            {
                throw new NothwindException("CategoriesBusiness - ListarPorNombreObjeto: " +
                    E.Message, E);
            }
        }

        /**
        * Este es un ejemplo practico de como podria hacer uniones entre dos listas
        * porque se reduce el codigo con Entity Framework o ADO haciendo la consulta directamente
        * */
        public List<CategoriesDto> ListarCategoriasConProductos()
        {
            try
            {
                List<CategoriesDto> ListaCategories = CategoriesDao.Listar();
                List<ProductsDto> ListaProducts = ProductsDao.Listar();
                var Categories = from C in ListaCategories
                                 select new CategoriesDto
                                 {
                                     CategoryID = C.CategoryID,
                                     CategoryName = C.CategoryName,
                                     Description = C.Description,
                                     Products = (from P in ListaProducts
                                                where P.CategoryID == C.CategoryID
                                                select P).ToList()
                                 };
                return Categories.ToList();
            }
            catch (Exception E)
            {
                throw new NothwindException("CategoriesBusiness - ListarCategoriasConProductos: " +
                    E.Message, E);
            }
        }

    }
}
