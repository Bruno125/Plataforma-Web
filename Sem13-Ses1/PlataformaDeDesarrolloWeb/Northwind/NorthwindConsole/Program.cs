using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importaciones
using NorthwindBusiness.Business;
using NorthwindEntity.Entity;
using System.Data;

namespace NorthwindConsole
{
    class Program
    {
        private static int Indice;
        static void Main(string[] args)
        {
            int Opcion;
            do
            {
                Opcion = MetodoOpcion();
                switch (Opcion)
                {
                    case 1:
                        InsertarCategoria();
                        break;
                    case 2:
                        ActualizarCategoria();
                        break;
                    case 3:
                        EliminarCategoria();
                        break;
                    case 4:
                        ObtenerCategoria();
                        break;
                    case 5:
                        ListarCategorias();
                        break;
                    case 6:
                        ListarNombres();
                        break;
                    case 7:
                        ListarNombresObjetos();
                        break;
                    case 8:
                        ListarProductosConCategorias();
                        break;
                    case 9:
                        ListarCategoriasConProductos();
                        break;
                    case 10:
                        InsertarProducto();
                        break;
                    case 11:
                        ActualizarProducto();
                        break;
                    case 12:
                        EliminarProducto();
                        break;
                    case 13:
                        ObtenerProducto();
                        break;
                    case 14:
                        ListarProducto();
                        break;
                }
            } while (Opcion != Indice);
        }

        public static int MetodoOpcion()
        {
            int Opcion = -1;
            do
            {
                Indice = 1;
                try
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\tMENU DE OPCIONES");
                    Console.WriteLine("\t\t================\n\n");
                    Console.WriteLine("\t\tMantenimiento de Categoria");
                    Console.WriteLine("\t\t--------------------------\n");
                    Console.WriteLine("[{0}] Insertar Categoria", Indice++);
                    Console.WriteLine("[{0}] Actualizar Categoria", Indice++);
                    Console.WriteLine("[{0}] Eliminar Categoria", Indice++);
                    Console.WriteLine("[{0}] Obtener Categoria", Indice++);
                    Console.WriteLine("[{0}] Listar Categoria", Indice++);
                    Console.WriteLine("[{0}] Obtener Nombres de Categorias", Indice++);
                    Console.WriteLine("[{0}] Obtener Objetos Categorias", Indice++);
                    Console.WriteLine("[{0}] Listar Productos con Categorias", Indice++);
                    Console.WriteLine("[{0}] Listar Categorias con Productos\n\n", Indice++);
                    Console.WriteLine("\t\tMantenimiento de Producto");
                    Console.WriteLine("\t\t-------------------------\n");
                    Console.WriteLine("[{0}] Insertar Producto", Indice++);
                    Console.WriteLine("[{0}] Actualizar Producto", Indice++);
                    Console.WriteLine("[{0}] Eliminar Producto", Indice++);
                    Console.WriteLine("[{0}] Obtener Producto", Indice++);
                    Console.WriteLine("[{0}] Listar Producto\n", Indice++);
                    Console.WriteLine("[{0}] Salir\n", Indice);
                    Console.WriteLine("Seleccione opción:");
                    Opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Opcion = -1;
                }

            } while (Opcion <= 0 || Opcion > Indice);
            return Opcion;
        }

        #region Mantenimiento de Categoria
        public static void InsertarCategoria()
        {
            try
            {
                CategoriesDto Categories = new CategoriesDto();
                CategoriesBusiness CategoriesBusiness = CategoriesBusiness.ObtenerInstancia();
                Console.WriteLine("Ingrese nombre: ");
                Categories.CategoryName = Console.ReadLine().Trim().ToUpper();
                Console.WriteLine("Ingrese descripción: ");
                Categories.Description = Console.ReadLine().Trim().ToUpper();
                CategoriesBusiness.Insertar(Categories);
                Console.WriteLine("Se inserto la categoria con ID {0}", Categories.CategoryID);
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }

        public static void ActualizarCategoria()
        {
            try
            {
                CategoriesDto Categories = new CategoriesDto();
                CategoriesBusiness CategoriesBusiness = CategoriesBusiness.ObtenerInstancia();
                Console.WriteLine("Ingrese ID: ");
                Categories.CategoryID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese nombre: ");
                Categories.CategoryName = Console.ReadLine().Trim().ToUpper();
                Console.WriteLine("Ingrese descripción: ");
                Categories.Description = Console.ReadLine().Trim().ToUpper();
                CategoriesBusiness.Actualizar(Categories);
                Console.WriteLine("Se actualizo la categoria");
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }
        public static void EliminarCategoria()
        {
            try
            {
                CategoriesBusiness CategoriesBusiness = CategoriesBusiness.ObtenerInstancia();
                Console.WriteLine("Ingrese ID: ");
                CategoriesBusiness.Eliminar(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Se elimino la categoria");
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }

        public static void ObtenerCategoria()
        {
            try
            {
                CategoriesBusiness CategoriesBusiness = CategoriesBusiness.ObtenerInstancia();
                Console.WriteLine("Ingrese ID: ");
                CategoriesDto Categories=  CategoriesBusiness.Obtener(Convert.ToInt32(Console.ReadLine()));
                if (Categories.CategoryName != null)
                {
                    Console.WriteLine("ID: {0}", Categories.CategoryID);
                    Console.WriteLine("Nombre: {0}", Categories.CategoryName);
                    Console.WriteLine("Descripcion: {0}", Categories.Description);
                }
                else
                {
                    Console.WriteLine("No existe una categoria con ese código");
                }
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }

        public static void ListarCategorias()
        {
            try
            {
                CategoriesBusiness CategoriesBusiness = CategoriesBusiness.ObtenerInstancia();
                List<CategoriesDto> ListaCategoriesDto = CategoriesBusiness.Listar();
                foreach (CategoriesDto CategoriesDto in ListaCategoriesDto)
                {
                    Console.WriteLine("{0} - {1}", CategoriesDto.CategoryID, CategoriesDto.CategoryName);
                }
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }

        public static void ListarNombres()
        {
            try
            {
                CategoriesBusiness CategoriesBusiness = CategoriesBusiness.ObtenerInstancia();
                Console.WriteLine("Ingrese filtro de busqueda: ");
                List<string> NombreCategorias = CategoriesBusiness.ListarPorNombre(
                    Console.ReadLine());
                foreach (string Nombre in NombreCategorias)
                {
                    Console.WriteLine("{0}", Nombre);
                }
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }

        public static void ListarNombresObjetos()
        {
            try
            {
                CategoriesBusiness CategoriesBusiness = CategoriesBusiness.ObtenerInstancia();
                Console.WriteLine("Ingrese filtro de busqueda: ");
                List<CategoriesDto> Categorias = CategoriesBusiness.ListarPorNombreObjeto(
                    Console.ReadLine());
                foreach (CategoriesDto C in Categorias)
                {
                    Console.WriteLine("{0} - {1}", C.CategoryID, C.CategoryName);
                }
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }

        public static void ListarProductosConCategorias()
        {
            try
            {
                ProductsBusiness ProductsBusiness = ProductsBusiness.ObtenerInstancia();
                List<ProductsDto> Productos = ProductsBusiness.ListarProductosConCategorias();
                foreach (ProductsDto P in Productos)
                {
                    Console.WriteLine("{0} - {1}", 
                        P.ProductName, 
                        P.Categories.CategoryName);
                }

            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }
        public static void ListarCategoriasConProductos()
        {
            try
            {
                CategoriesBusiness CategoriesBusiness = CategoriesBusiness.ObtenerInstancia();
                List<CategoriesDto> Categorias = CategoriesBusiness.ListarCategoriasConProductos();
                foreach (CategoriesDto C in Categorias)
                {
                    Console.WriteLine("{0} - {1}", C.CategoryID, C.CategoryName);
                    foreach (ProductsDto P in C.Products)
                    {
                        Console.WriteLine("\t{0} - {1}", P.ProductID, P.ProductName);
                    }

                }
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }
        #endregion


        #region Mantenimiento de Producto

        public static void InsertarProducto()
        {
            try
            {
                ProductsDto Products = new ProductsDto();
                ProductsBusiness ProductsBusiness = ProductsBusiness.ObtenerInstancia();
                Console.WriteLine("Ingrese ProductName: ");
                Products.ProductName = Console.ReadLine().Trim().ToUpper();
                Console.WriteLine("Ingrese SupplierID: ");
                Products.SupplierID = Int32.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Ingrese CategoryID: ");
                Products.CategoryID = Int32.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Ingrese QuantityPerUnit: ");
                Products.QuantityPerUnit = Console.ReadLine().Trim().ToUpper();
                Console.WriteLine("Ingrese UnitPrice: ");
                Products.UnitPrice = Decimal.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Ingrese UnitsInStock: ");
                Products.UnitsInStock = Int32.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Ingrese UnitsOnOrder: ");
                Products.UnitsOnOrder = Int32.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Ingrese ReorderLevel: ");
                Products.ReorderLevel = Int32.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Ingrese Discontinued: ");
                Products.Discontinued =bool.Parse(Console.ReadLine().Trim());
                ProductsBusiness.Insertar(Products);
                Console.WriteLine("Se inserto el Producto con ID {0}", Products.ProductID);
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }

        public static void ActualizarProducto()
        {
            try
            {
                ProductsDto Products = new ProductsDto();
                ProductsBusiness ProductsBusiness = ProductsBusiness.ObtenerInstancia();
                Console.WriteLine("Ingrese ProductID: ");
                Products.ProductID = Int32.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Ingrese ProductName: ");
                Products.ProductName = Console.ReadLine().Trim().ToUpper();
                Console.WriteLine("Ingrese SupplierID: ");
                Products.SupplierID = Int32.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Ingrese CategoryID: ");
                Products.CategoryID = Int32.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Ingrese QuantityPerUnit: ");
                Products.QuantityPerUnit = Console.ReadLine().Trim().ToUpper();
                Console.WriteLine("Ingrese UnitPrice: ");
                Products.UnitPrice = Decimal.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Ingrese UnitsInStock: ");
                Products.UnitsInStock = Int32.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Ingrese UnitsOnOrder: ");
                Products.UnitsOnOrder = Int32.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Ingrese ReorderLevel: ");
                Products.ReorderLevel = Int32.Parse(Console.ReadLine().Trim());
                Console.WriteLine("Ingrese Discontinued: ");
                Products.Discontinued = bool.Parse(Console.ReadLine().Trim());
                ProductsBusiness.Actualizar(Products);
                Console.WriteLine("Se actualizo el Producto ");
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }

        public static void EliminarProducto()
        {
            try
            {
                ProductsBusiness ProductsBusiness = ProductsBusiness.ObtenerInstancia();
                Console.WriteLine("Ingrese ProductID: ");
                ProductsBusiness.Eliminar(Int32.Parse(Console.ReadLine().Trim()));
                Console.WriteLine("Se elimino el Producto ");
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }


        public static void ObtenerProducto()
        {
            try
            {
                ProductsBusiness ProductsBusiness = ProductsBusiness.ObtenerInstancia();
                Console.WriteLine("Ingrese ProductID: ");
                ProductsDto Products  = ProductsBusiness.Obtener(Int32.Parse(Console.ReadLine().Trim()));
                if (Products.ProductName != null)
                {
                    Console.WriteLine("ProductID : {0}", Products.ProductID);
                    Console.WriteLine("ProductName : {0}", Products.ProductName);
                    Console.WriteLine("SupplierID : {0}", Products.SupplierID);
                    Console.WriteLine("CategoryID : {0}", Products.CategoryID);
                    Console.WriteLine("QuantityPerUnit : {0}", Products.QuantityPerUnit);
                    Console.WriteLine("UnitPrice : {0}", Products.UnitPrice);
                    Console.WriteLine("UnitsInStock : {0}", Products.UnitsInStock);
                    Console.WriteLine("UnitsOnOrder : {0}", Products.UnitsOnOrder);
                    Console.WriteLine("ReorderLevel : {0}", Products.ReorderLevel);
                    Console.WriteLine("Discontinued : {0}", Products.Discontinued);
                }
                else
                {
                    Console.WriteLine("El producto no existe");
                }
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }

        public static void ListarProducto()
        {
            try
            {
                ProductsBusiness ProductsBusiness = ProductsBusiness.ObtenerInstancia();
                List<ProductsDto> ListaProducts = ProductsBusiness.Listar();
                foreach(ProductsDto Products in ListaProducts)
                {
                    Console.WriteLine("ProductID : {0}", Products.ProductID);
                    Console.WriteLine("ProductName : {0}", Products.ProductName);
                    Console.WriteLine("SupplierID : {0}", Products.SupplierID);
                    Console.WriteLine("CategoryID : {0}", Products.CategoryID);
                    Console.WriteLine("QuantityPerUnit : {0}", Products.QuantityPerUnit);
                    Console.WriteLine("UnitPrice : {0}", Products.UnitPrice);
                    Console.WriteLine("UnitsInStock : {0}", Products.UnitsInStock);
                    Console.WriteLine("UnitsOnOrder : {0}", Products.UnitsOnOrder);
                    Console.WriteLine("ReorderLevel : {0}", Products.ReorderLevel);
                    Console.WriteLine("Discontinued : {0}", Products.Discontinued);
                    Console.WriteLine("");
                }
               
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }

        #endregion
    }
}
