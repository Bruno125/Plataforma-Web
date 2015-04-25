using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindEntity.Entity;
using NorthwindUtil.ExceptionPer;
using NorthwindDao.Base;
using System.Data;
namespace NorthwindDao.Dao.Framework
{
    public sealed class CategoriesFramework : ICategoriesDao
    {
        #region Patron singleton
        private static CategoriesFramework CATEGORIES_FRAMEWORK = new CategoriesFramework();
        private CategoriesFramework() { }
        public static CategoriesFramework ObtenerInstancia()
        {
            return CATEGORIES_FRAMEWORK;
        }

        #endregion

        private NorthwindEntities NorthwindEntities = new NorthwindEntities();

        public List<string> ListarPorNombre(string Nombre)
        {
            throw new NotImplementedException();
        }

        public List<Categories> ListarPorNombreObject(string Nombre)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Categories Entity)
        {
            try
            {
                Category Category = new Category() 
                {
                    CategoryID = Entity.CategoryId,
                    CategoryName = Entity.CategoryName,
                    Description = Entity.Description 
                };
                NorthwindEntities.Categories.Add(Category);
                NorthwindEntities.SaveChanges();
            }
            catch (Exception E)
            {
                throw new NorthwindException("CategoriesFramework insertar: " + E.Message, E);
            }
        }

        public void Actualizar(Categories Entity)
        {
            try
            {
                //Primero buscar el objeto en el Id del objeto enviado en la base de datos
                Category Category = NorthwindEntities.Categories.Single(c => c.CategoryID == Entity.CategoryId);
                Category.CategoryID = Entity.CategoryId;
                Category.CategoryName = Entity.CategoryName;
                Category.Description = Entity.Description;

                NorthwindEntities.SaveChanges();
            }
            catch (Exception E)
            {
                throw new NorthwindException("CategoriesFramework actualizar: " + E.Message, E);
            }
        }

        public void Eliminar(int Id)
        {
            try
            {
                Category Category = NorthwindEntities.Categories.Single( c => c.CategoryID == Id);
                NorthwindEntities.Categories.Remove(Category);
                NorthwindEntities.SaveChanges();

            }
            catch (Exception E)
            {
                throw new NorthwindException("CategoriesFramework eliminar: " + E.Message, E);

            }
        }

        public Categories Obtener(int id)
        {
            Categories Categories = new Categories();
            try
            {
                Category Category = NorthwindEntities.Categories.Single(c => c.CategoryID == id);
                Categories.CategoryId = Category.CategoryID;
                Categories.CategoryName = Category.CategoryName;
                Categories.Description = Category.Description;
            }
            catch (Exception E)
            {
                throw new NorthwindException("CategoriesFramework obtener: " + E.Message, E);
            }
            return Categories;
        }
        //NO debería devolver DataTable. Se hizo así por 
        public DataTable Listar()
        {
            DataTable DtCategories = new DataTable();
            try
            {
                IEnumerable<Category> ListaCategories = NorthwindEntities.Categories.ToList();
                DtCategories = NorthwindDao.Dao.Ado.CategoriesAdo.ObtenerInstancia().Listar();
            }
            catch (Exception E)
            {
                throw new NorthwindException("CategoriesFramework obtener: " + E.Message, E);
            }
            return DtCategories;
        }
    }
}
