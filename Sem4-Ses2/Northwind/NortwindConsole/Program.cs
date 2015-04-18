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
                Console.WriteLine("Se inserto la categoria con ID {0}", Categories.CategoryId);
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
    }
}
