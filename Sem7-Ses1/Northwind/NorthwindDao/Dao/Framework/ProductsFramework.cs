using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importaciones
using NorthwindEntity.Entity;
using NorthwindUtil.ExceptionPer;
using NorthwindDao.Base;
using System.Data;

namespace NorthwindDao.Dao.Framework
{
    public sealed class ProductsFramework: IProductsDao
    {

        #region Patron Singleton
        private static ProductsFramework PRODUCTS_FRAMEWORK = new ProductsFramework();
        private ProductsFramework()
        {

        }

        public static ProductsFramework ObtenerInstancia()
        {
            return PRODUCTS_FRAMEWORK;
        }
        #endregion
        //Tienen todos los metodos para trabajar con el entity framework
        private NorthwindEntities NorthwindEntities = new NorthwindEntities();

        public void Insertar(ProductsDto Entity)
        {
            try
            {
                Product Product = new Product();
                Product.ProductID = Entity.ProductID;
                Product.ProductName = Entity.ProductName.ToUpper();
                Product.SupplierID = (int)Entity.SupplierID;
                Product.CategoryID = (int)Entity.CategoryID;
                Product.QuantityPerUnit = Entity.QuantityPerUnit;
                Product.UnitPrice = (int)Entity.UnitPrice;
                Product.UnitsInStock = (short)Entity.UnitsInStock;
                Product.UnitsOnOrder = (short)Entity.UnitsOnOrder;
                Product.ReorderLevel = (short)Entity.ReorderLevel;
                Product.Discontinued = (bool)Product.Discontinued;
                NorthwindEntities.Products.Add(Product);
                NorthwindEntities.SaveChanges();
                Entity.ProductID = Product.ProductID;
            }
            catch (Exception E)
            {
                throw new NothwindException("Products Framework - Insertar: " +
                    E.Message, E);
            }
        }

        public void Actualizar(ProductsDto Entity)
        {
            try
            {
                Product Product = NorthwindEntities.Products.Single(P => P.ProductID == Entity.ProductID); 
                Product.ProductName = Entity.ProductName.ToUpper();
                Product.SupplierID = (int)Entity.SupplierID;
                Product.CategoryID = (int)Entity.CategoryID;
                Product.QuantityPerUnit = Entity.QuantityPerUnit;
                Product.UnitPrice = (int)Entity.UnitPrice;
                Product.UnitsInStock = (short)Entity.UnitsInStock;
                Product.UnitsOnOrder = (short)Entity.UnitsOnOrder;
                Product.ReorderLevel = (short)Entity.ReorderLevel;
                Product.Discontinued = (bool)Product.Discontinued;
                NorthwindEntities.SaveChanges();
            }
            catch (Exception E)
            {
                throw new NothwindException("Products Framework - Actualizar: " +
                    E.Message, E);
            }
        }

        public void Eliminar(int Id)
        {
            try
            {
                Product Product = NorthwindEntities.Products.Single(P => P.ProductID == Id);
                NorthwindEntities.Products.Remove(Product);
                NorthwindEntities.SaveChanges();

            }
            catch (Exception E)
            {
                throw new NothwindException("Products Framework - Eliminar: " +
                    E.Message, E);
            }
        }

        public ProductsDto Obtener(int Id)
        {
            ProductsDto ProductsDto = new ProductsDto();
            try
            {
                Product Product = NorthwindEntities.Products.Single(P => P.ProductID == Id);
                if (Product != null)
                {
                    ProductsDto.ProductID = Product.ProductID;
                    ProductsDto.ProductName = Product.ProductName.ToUpper();
                    ProductsDto.SupplierID = (int)Product.SupplierID;
                    ProductsDto.CategoryID = (int)Product.CategoryID;
                    ProductsDto.QuantityPerUnit = Product.QuantityPerUnit;
                    ProductsDto.UnitPrice = (int)Product.UnitPrice;
                    ProductsDto.UnitsInStock = (short)Product.UnitsInStock;
                    ProductsDto.UnitsOnOrder = (short)Product.UnitsOnOrder;
                    ProductsDto.ReorderLevel = (short)Product.ReorderLevel;
                    ProductsDto.Discontinued = Product.Discontinued;
                }
            }
            catch (Exception E)
            {
                throw new NothwindException("Products Framework - Obtener: " +
                    E.Message, E);
            }
            return ProductsDto;
        }

        public List<ProductsDto> Listar()
        {
            List<ProductsDto> ListaProductsDto = new List<ProductsDto>();
            try
            {
                IEnumerable<Product> ListaProducts = NorthwindEntities.Products.ToList();
                foreach (Product Product in ListaProducts)
                {
                    ProductsDto ProductsDto = new ProductsDto();
                    ProductsDto.ProductID =Product.ProductID;
                    ProductsDto.ProductName =Product.ProductName.ToUpper();
                    ProductsDto.SupplierID = (int)Product.SupplierID;
                    ProductsDto.CategoryID = (int)Product.CategoryID;
                    ProductsDto.QuantityPerUnit =Product.QuantityPerUnit;
                    ProductsDto.UnitPrice = (int)Product.UnitPrice;
                    ProductsDto.UnitsInStock =(short)Product.UnitsInStock;
                    ProductsDto.UnitsOnOrder = (short)Product.UnitsOnOrder;
                    ProductsDto.ReorderLevel = (short)Product.ReorderLevel;
                    ProductsDto.Discontinued = Product.Discontinued;
                    ListaProductsDto.Add(ProductsDto);
                }
            }
            catch (Exception E)
            {
                throw new NothwindException("Products Framework - Listar: " +
                    E.Message, E);
            }
            return ListaProductsDto;
        }

       
    }
}
