using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindBussiness.Business;
using NorthwindEntity.Entity;
using NorthwindUtil.ExceptionPer;
namespace NortwindConsole
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
                    case 6:
                        ListarNombres();
                        break;
                    case 7:
                        ListarObjetos();
                        break;
                    case 8:
                        ListarProductosConCategorias();
                        break;
                    case 9:
                        InsertarProducto();
                        break;
                    case 10:
                        ActualizarProducto();
                        break;
                    case 11:
                        EliminarProducto();
                        break;
                    case 12:
                        ObtenerProducto();
                        break;
                    case 13:
                        ListarProductos();
                        break;
                    case 14:
                        ListarProductosPorCategoria();
                        break;
                }
            } while (Opcion != Indice);
        }

        public static int MetodoOpcion()
        {
            int Opcion = -1;
            do{
                Indice = 1;
                try{
                    Console.WriteLine("\n\n");
                    Console.WriteLine("\t\t MENU DE OPCIONES");
                    Console.WriteLine("\t\t=================");
                    Console.WriteLine("[{0}] Insertar Categoria", Indice++);
                    Console.WriteLine("[{0}] Actualizar Categoria", Indice++);
                    Console.WriteLine("[{0}] Eliminar Categoria", Indice++);
                    Console.WriteLine("[{0}] Obtener Categoria", Indice++);
                    Console.WriteLine("[{0}] Listar Categoria", Indice++);
                    Console.WriteLine("[{0}] Obtener Nombres de Categorias", Indice++);
                    Console.WriteLine("[{0}] Listar objetos por nombre", Indice++);
                    Console.WriteLine("[{0}] Listar productos con categorias", Indice++);
                    Console.WriteLine("[{0}] Insertar Producto", Indice++);
                    Console.WriteLine("[{0}] Actualizar Producto", Indice++);
                    Console.WriteLine("[{0}] Eliminar Producto", Indice++);
                    Console.WriteLine("[{0}] Obtener Producto", Indice++);
                    Console.WriteLine("[{0}] Listar Productos", Indice++);
                    Console.WriteLine("[{0}] Listar productos por categoria", Indice++);
                    Console.WriteLine("[{0}] Salir", Indice);
                    Console.WriteLine("Seleccione opcion: ");
                    Opcion = Convert.ToInt32(Console.ReadLine());
                }catch(Exception)
                {
                    Opcion = -1;
                }
            }while(Opcion<=0 || Opcion>Indice);
            return Opcion;
        }

        public static void InsertarCategoria()
        {
            try
            {
                Categories Categories = new Categories();
                CategoriesBusiness CategoriesBusiness = new CategoriesBusiness();
                Console.WriteLine("Ingrese nombre: ");
                Categories.CategoryName = Console.ReadLine().Trim().ToUpper();
                Console.WriteLine("Ingrese descripcion: ");
                Categories.Description = Console.ReadLine().Trim().ToUpper();
                CategoriesBusiness.Insertar(Categories);
                Console.WriteLine("Se inserto una nueva categoria");
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: "+ E.Message);
            }
        }

        public static void ActualizarCategoria()
        {
            try
            {
                Categories Categories = new Categories();
                CategoriesBusiness CategoriesBusiness = new CategoriesBusiness();
                Console.WriteLine("Ingrese id: ");
                Categories.CategoryId = Convert.ToInt32(Console.ReadLine().Trim().ToUpper());
                Console.WriteLine("Ingrese nombre: ");
                Categories.CategoryName = Console.ReadLine().Trim().ToUpper();
                Console.WriteLine("Ingrese descripcion: ");
                Categories.Description = Console.ReadLine().Trim().ToUpper();
                CategoriesBusiness.Actualizar(Categories);
                Console.WriteLine("Se actualizo la categoria con ID {0}", Categories.CategoryId);
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
                CategoriesBusiness CategoriesBusiness = new CategoriesBusiness();
                Console.WriteLine("Ingrese id: ");
                int id = Convert.ToInt32(Console.ReadLine().Trim().ToUpper());
                CategoriesBusiness.Eliminar(id);
                Console.WriteLine("Se elimino la categoria con ID {0}", id);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }

        public static void ListarNombres()
        {
            try
            {
                CategoriesBusiness CategoriesBusiness = new CategoriesBusiness();
                Console.WriteLine("Ingrese filtro de busqueda: ");
                List<string> NombreCategorias = CategoriesBusiness.ListarPorNombre(Console.ReadLine());
                foreach(string Nombre in NombreCategorias)
                {
                    Console.WriteLine("{0}",Nombre);
                }
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }

        public static void ListarObjetos()
        {
            try
            {
                CategoriesBusiness CategoriesBusiness = new CategoriesBusiness();
                Console.WriteLine("Ingrese filtro de busqueda: ");
                List<Categories> NombreCategorias = CategoriesBusiness.ListarObjetoPorNombre(Console.ReadLine());
                foreach (Categories Objeto in NombreCategorias)
                {
                    Console.WriteLine("{0} - {1}: {2}", Objeto.CategoryId,Objeto.CategoryName,Objeto.Description);
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
                ProductsBusiness ProductsBusiness = new ProductsBusiness();
                List<Products> Productos = ProductsBusiness.ListarProductosConCategorias();
                foreach (Products p in Productos)
                {
                    Console.WriteLine("{0} - {1}", p.ProductName, p.Categories.CategoryName);
                }
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }


        public static void InsertarProducto()
        {
            try
            {
                Products Products = new Products();
                ProductsBusiness ProductsBusiness = new ProductsBusiness();
                Console.WriteLine("Ingrese nombre: ");
                Products.ProductName = Console.ReadLine().Trim().ToUpper();
                Console.WriteLine("Ingrese cantidad por unidad: ");
                Products.QuantityPerUnit = Console.ReadLine().Trim().ToUpper();
                Console.WriteLine("Ingrese precio unitario: ");
                Products.UnitPrice = Decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese unidades en stock: ");
                Products.UnitsInStock = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese unidades en orden: ");
                Products.UnitsOnOrder = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nivel de reorden: ");
                Products.ReorderLevel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("¿Esta descontinuado? (1: si | 0: no): ");
                Products.Discontinued = Console.ReadLine().Equals("1");
                Console.WriteLine("Ingrese id del proveedor: ");
                Products.SupplierId = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese id de la categoria: ");
                Products.CategoryId = Int32.Parse(Console.ReadLine());

                ProductsBusiness.Insertar(Products);
                Console.WriteLine("Se inserto un nuevo producto");
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
                Products Products = new Products();
                ProductsBusiness ProductsBusiness = new ProductsBusiness();
                Console.WriteLine("Ingrese id: ");
                Products.ProductId = Convert.ToInt32(Console.ReadLine().Trim().ToUpper());
                Console.WriteLine("Ingrese nombre: ");
                Products.ProductName = Console.ReadLine().Trim().ToUpper();
                Console.WriteLine("Ingrese cantidad por unidad: ");
                Products.QuantityPerUnit = Console.ReadLine().Trim().ToUpper();
                Console.WriteLine("Ingrese precio unitario: ");
                Products.UnitPrice = Decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese unidades en stock: ");
                Products.UnitsInStock = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese unidades en orden: ");
                Products.UnitsOnOrder = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nivel de reorden: ");
                Products.ReorderLevel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("¿Esta descontinuado? (1: si | 0: no): ");
                Products.Discontinued = Console.ReadLine().Equals("1");
                Console.WriteLine("Ingrese id del proveedor: ");
                Products.SupplierId = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese id de la categoria: ");
                Products.CategoryId = Int32.Parse(Console.ReadLine());

                ProductsBusiness.Actualizar(Products);
                Console.WriteLine("Se actualizo el producto con ID {0}", Products.ProductId);
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
                ProductsBusiness ProductsBusiness = new ProductsBusiness();
                Console.WriteLine("Ingrese id: ");
                int id = Convert.ToInt32(Console.ReadLine().Trim().ToUpper());
                ProductsBusiness.Eliminar(id);
                Console.WriteLine("Se elimino el producto con ID {0}", id);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }

        public static void ObtenerProducto()
        {
            try
            {
                ProductsBusiness ProductsBusiness = new ProductsBusiness();
                Console.WriteLine("Ingrese id: ");
                int id = Convert.ToInt32(Console.ReadLine().Trim().ToUpper());
                Products Entity = ProductsBusiness.Obtener(id);

                Console.WriteLine("Detalle del producto con ID:" + id);
                Console.WriteLine("================================");
                Console.WriteLine("\tNombre:" + Entity.ProductName);
                Console.WriteLine("\tSupplierId:" + Entity.SupplierId);
                Console.WriteLine("\tCategoryId:" + Entity.CategoryId);
                Console.WriteLine("\tQuantityPerUnit:" + Entity.QuantityPerUnit);
                Console.WriteLine("\tUnitPrice:" + Entity.UnitPrice);
                Console.WriteLine("\tUnitsInStock:" + Entity.UnitsInStock);
                Console.WriteLine("\tUnitsOnOrder:" + Entity.UnitsOnOrder);
                Console.WriteLine("\tReorderLevel:" + Entity.ReorderLevel);
                Console.WriteLine("\tDiscontinued:" + ((Entity.Discontinued)?"si":"no"));

            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }

        public static void ListarProductos()
        {
            try
            {
                ProductsBusiness ProductsBusiness = new ProductsBusiness();
                List<Products> NombreCategorias = ProductsBusiness.ListarPorObjetoProducts();
                foreach (Products Objeto in NombreCategorias)
                {
                    Console.WriteLine("{0} - {1}", Objeto.ProductId, Objeto.ProductName);
                }
            }
            catch (Exception E)
            {
                Console.WriteLine("Ocurrio un error: " + E.Message);
            }
        }

        public static void ListarProductosPorCategoria()
        {
            Console.WriteLine("LISTADO CATEGORIAS POR PRODUCTO");
            Console.WriteLine("===============================");
            ProductsBusiness ProductsBusiness = new ProductsBusiness();
            var ListaProductosPorCategoria = ProductsBusiness.ListarProductosPorCategoria();
            foreach (var entry in ListaProductosPorCategoria)
            {
                Categories Categories = entry.Key;
                Console.WriteLine("{0} - {1}", Categories.CategoryId, Categories.CategoryName);
                foreach (Products Products in entry.Value)
                {
                    Console.WriteLine("\t{0}  - {1}",Products.ProductId,Products.ProductName);
                }
            }

        }
    }
}
