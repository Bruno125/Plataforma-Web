using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importaciones
using NorthwindBusiness.Base;
using NorthwindDao.Dao;
using NorthwindEntity.Entity;
using NorthwindUtil.ExceptionPer;
using NorthwindBusiness.Util;

namespace NorthwindBusiness.Business
{
    public sealed class ProductsBusiness : BaseBusiness<ProductsDto, int>
    {

        #region
        private static ProductsBusiness PRODUCTS_BUSINESS = new ProductsBusiness();
        private ProductsBusiness()
        {

        }
        public static ProductsBusiness ObtenerInstancia()
        {
            return PRODUCTS_BUSINESS;
        }
        #endregion

        private IProductsDao ProductsDao = 
            (IProductsDao)UtilBusiness.ObtenerInstancia(UtilBusiness.Clase.Products);

        private ICategoriesDao CategoriesDao =
            (ICategoriesDao)UtilBusiness.ObtenerInstancia(UtilBusiness.Clase.Categories);

        public void Insertar(ProductsDto Entity)
        {
            try
            {
                ProductsDao.Insertar(Entity);
            }
            catch (Exception E)
            {
                throw new NothwindException("ProductsBusiness - Insertar: " +
                    E.Message, E);
            }
        }

        public void Actualizar(ProductsDto Entity)
        {
            try
            {
                ProductsDao.Actualizar(Entity);
            }
            catch (Exception E)
            {
                throw new NothwindException("ProductsBusiness - Actualizar: " +
                    E.Message, E);
            }
        }

        public void Eliminar(int Id)
        {
            try
            {
                ProductsDao.Eliminar(Id);
            }
            catch (Exception E)
            {
                throw new NothwindException("ProductsBusiness - Eliminar: " +
                    E.Message, E);
            }
        }

        public ProductsDto Obtener(int Id)
        {
            try
            {
                return ProductsDao.Obtener(Id);
            }
            catch (Exception E)
            {
                throw new NothwindException("ProductsBusiness - Obtener: " +
                    E.Message, E);
            }
        }

        public List<ProductsDto> Listar()
        {
            try
            {
                return ProductsDao.Listar();
            }
            catch (Exception E)
            {
                throw new NothwindException("ProductsBusiness - Listar: " +
                    E.Message, E);
            }
        }

        /**
         * Este es un ejemplo practico de como podria hacer uniones entre dos listas
         * porque se reduce el codigo con Entity Framework o ADO haciendo la consulta directamente
         * */
        public List<ProductsDto> ListarProductosConCategorias()
        {
            List<ProductsDto> ListaProductsDtoResultado = new List<ProductsDto>();
            try
            {
                List<ProductsDto> ListaProductsDto = ProductsDao.Listar();
                List<CategoriesDto> ListaCategoriesDto = CategoriesDao.Listar();
                var Productos = ListaProductsDto.Join(
                    ListaCategoriesDto.AsEnumerable(),
                    p => p.CategoryID,
                    c => c.CategoryID,
                    (p, c) => new ProductsDto
                        {
                            ProductID = p.ProductID,
                            ProductName = p.ProductName.ToUpper(),
                            QuantityPerUnit = p.QuantityPerUnit,
                            UnitPrice = p.UnitPrice,
                            UnitsInStock = p.UnitsInStock,
                            UnitsOnOrder = p.UnitsOnOrder,
                            Categories = new CategoriesDto()
                            {
                                CategoryID = p.CategoryID,
                                CategoryName = c.CategoryName,
                                Description = c.Description
                            }
                        }
                    );
                ListaProductsDtoResultado = Productos.ToList();
            }
            catch (Exception E)
            {
                throw new NothwindException("Products Business - ListarProductosConCategorias: "
                    + E.Message, E);
            }
            return ListaProductsDtoResultado;
        }

       
    }
}
