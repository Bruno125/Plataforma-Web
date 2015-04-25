using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindBussiness.Base;
using NorthwindEntity.Entity;
using NorthwindUtil.ExceptionPer;
using NorthwindDao.Dao;
using System.Data;
using NorthwindBussiness.Util;

namespace NorthwindBussiness.Business
{
    public class ProductsBusiness : BaseBusiness<Products,int>
    {
        #region
        private static ProductsBusiness PRODUCTS_BUSINESS = new ProductsBusiness();
        private ProductsBusiness() { }
        public static ProductsBusiness ObtenerInstancia()
        {
            return PRODUCTS_BUSINESS;
        }
        #endregion


        
        private IProductsDao ProductsDao = UtilBusiness.ObtenerInstancia(UtilBusiness.Clase.Products) as IProductsDao;
        private ICategoriesDao CategoriesDao = UtilBusiness.ObtenerInstancia(UtilBusiness.Clase.Categories) as ICategoriesDao;

        public void Insertar(Products Entity)
        {
            try
            {
                ProductsDao.Insertar(Entity);
            }
            catch (Exception E)
            {
                throw new NorthwindException("NorthwindwBusiness - Insertar producto: " + E.Message);
            }
        }

        public void Actualizar(Products Entity)
        {
            try
            {
                ProductsDao.Actualizar(Entity);
            }
            catch (Exception E)
            {
                throw new NorthwindException("NorthwindwBusiness - Insertar producto: " + E.Message);
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                ProductsDao.Eliminar(id);
            }
            catch (Exception E)
            {
                throw new NorthwindException("NorthwindwBusiness - Insertar producto: " + E.Message);
            }
        }

        public Products Obtener(int id)
        {
            try
            {
                return ProductsDao.Obtener(id);
            }
            catch (Exception E)
            {
                throw new NorthwindException("NorthwindwBusiness - Insertar producto: " + E.Message);
            }
        }

        public DataTable Listar()
        {
            try
            {
                return ProductsDao.Listar();
            }
            catch (Exception E)
            {
                throw new NorthwindException("NorthwindwBusiness - Listar productos: " + E.Message);
            }
        }

        #region LinQ

        public List<Products> ListarProductosConCategorias()
        {
            List<Products> ListProductos = new List<Products>();
            try
            {
                DataTable DtProductos = ProductsDao.Listar();
                DataTable DtCategories = CategoriesDao.Listar();

                //var ProductosConCategorias = from p in DtProductos.AsEnumerable()
                //                             join c in DtCategories.AsEnumerable()
                //                             on p.Field<int>("ProductID") equals c.Field<int>("CategoryID")
                //                             select new Products
                //                             {
                //                                 ProductId = p.Field<int>("ProductID"),
                //                                 ProductName = p.Field<string>("ProductName"),
                //                                 QuantityPerUnit = p.Field<string>("QuantityPerUnit"),
                //                                 UnitPrice = p.Field<decimal>("UnitPrice"),
                //                                 UnitsInStock = p.Field<Int16>("UnitsInStock"),
                //                                 UnitsInOrder = p.Field<Int16>("UnitsInOrder"),
                //                                 Categories = new Categories
                //                                 {
                //                                     CategoryId = c.Field<int>("CategoryID"),
                //                                     CategoryName = c.Field<string>("CategoryName"),
                //                                     Description = c.Field<string>("Description")
                //                                 }
                //                             };

                var ProductosConCategorias = DtProductos.AsEnumerable().Join(
                    DtCategories.AsEnumerable(),
                    p => p.Field<int>("CategoryID"), 
                    c => c.Field<int>("CategoryID"),
                    (p, c) => new Products
                        {
                            ProductId = p.Field<int>("ProductID"),
                            ProductName = p.Field<string>("ProductName"),
                            QuantityPerUnit = p.Field<string>("QuantityPerUnit"),
                            UnitPrice = p.Field<decimal>("UnitPrice"),
                            UnitsInStock = p.Field<Int16>("UnitsInStock"),
                            UnitsInOrder = p.Field<Int16>("UnitsOnOrder"),
                            Categories = new Categories
                            {
                                CategoryId = c.Field<int>("CategoryID"),
                                CategoryName = c.Field<string>("CategoryName"),
                                Description = c.Field<string>("Description")
                            }
                        }
                    );

                ListProductos = ProductosConCategorias.ToList();
            }catch(Exception E)
            {
                throw new NorthwindException("NorthwindBusiness - ListarProductosConCategorias : " + E.Message);
            }
            return ListProductos;
        }

        #endregion

    }
}
