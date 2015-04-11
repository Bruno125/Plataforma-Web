using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWindDAO.Entity;
using NorthWindDAO.Dao;
using System.Data;

namespace NorthWindConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Eliminar();
        }

        public static void Insertar()
        {
            string Nombre, Descripcion;
            Categories Categories = new Categories();
            CategoriesDao CategoriesDao = new CategoriesDao();
            Console.WriteLine("Ingrese nombre: ");
            Nombre = Console.ReadLine().Trim().ToUpper();
            Console.WriteLine("Ingrese descripcion: ");
            Descripcion = Console.ReadLine().Trim().ToUpper();
            //Estableciendo parametros para el objeto categories
            Categories.CategoryName = Nombre;
            Categories.Description = Descripcion;
            //Invocando al metodo insertar de CategoriesDao
            CategoriesDao.Insertar(Categories);
            Console.WriteLine("Se inserto la categoria de manera correcta");
            Console.ReadLine();
        }

        public static void Actualizar()
        {
            Categories Categories = new Categories();
            CategoriesDao CategoriesDao = new CategoriesDao();
            Console.WriteLine("Ingrese ID: ");
            Categories.CategoryId = Int32.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Ingrese nombre: ");
            Categories.CategoryName = Console.ReadLine().Trim().ToUpper();
            Console.WriteLine("Ingrese descripcion: ");
            Categories.Description = Console.ReadLine().Trim().ToUpper();

            CategoriesDao.Actualizar(Categories);

            Console.WriteLine("Se actualizo la categoria de manera correcta");
            Console.ReadLine();

        }

        public static void Lista()
        {
            CategoriesDao CategoriesDao = new CategoriesDao();
            DataTable DtCategories = CategoriesDao.Listar();
            foreach (DataRow Row in DtCategories.Rows)
            {
                Console.WriteLine("{0} - {1}", Row["CategoryId"].ToString(), Row["CategoryName"].ToString());
            }

            Console.ReadLine();
        }

        public static void Obtener()
        {
            CategoriesDao CategoriesDao = new CategoriesDao();
            Console.WriteLine("Ingrese ID: ");
            int id = Int32.Parse(Console.ReadLine().Trim());
            Categories Categories = CategoriesDao.Obtener(id);
            Console.WriteLine("Nombre: {0}", Categories.CategoryName);
            Console.WriteLine("Descripcion: {0}", Categories.Description);
            Console.ReadLine();

        }

        public static void Eliminar()
        {
            CategoriesDao CategoriesDao = new CategoriesDao();
            Console.WriteLine("Ingrese ID: ");
            int id = Int32.Parse(Console.ReadLine().Trim());
            CategoriesDao.Eliminar(id);
            Console.WriteLine("Se elimino satisfactoriamente");
            Console.ReadLine();
        }
    }
}
