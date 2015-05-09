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
    public sealed class CategoriesFramework : ICategoriesDao
    {
        #region Patron Singleton
        private static CategoriesFramework CATEGORIES_FRAMEWORK = new CategoriesFramework();
        private CategoriesFramework()
        {

        }

        public static CategoriesFramework ObtenerInstancia()
        {
            return CATEGORIES_FRAMEWORK;
        }
        #endregion
        //Tienen todos los metodos para trabajar con el entity framework
        private NorthwindEntities NorthwindEntities = new NorthwindEntities();


        public List<string> ListarPorNombre(string Nombre)
        {
            List<string> ListaNombre = new List<string>();
            try
            {
                var NombreCategorias = from fila in NorthwindEntities.Categories
                                       where fila.CategoryName.ToUpper().Contains(Nombre.ToUpper())
                                       orderby fila.CategoryName.ToUpper() descending
                                       select fila.CategoryName.ToUpper();
                
                ListaNombre = NombreCategorias.ToList();
            }
            catch (Exception E)
            {
                throw new NothwindException("Categories Framework - ListarPorNombre: " +
                   E.Message, E);
            }
            return ListaNombre;
        }

        public List<CategoriesDto> ListarPorNombreObjeto(string Nombre)
        {
            List<CategoriesDto> ListaCategories = new List<CategoriesDto>();
            try
            {
                var Categorias = from fila in NorthwindEntities.Categories
                                 where fila.CategoryName.ToUpper().Contains(Nombre.ToUpper())
                                 orderby fila.CategoryName.ToUpper() descending
                                 select new CategoriesDto
                                 {
                                     CategoryID = fila.CategoryID,
                                     CategoryName = fila.CategoryName.ToUpper(),
                                     Description = fila.Description
                                 };
                ListaCategories = Categorias.ToList();
            }
            catch (Exception E)
            {

                throw new NothwindException("Categories Framework - ListarPorNombreObjeto: " +
                   E.Message, E);
            }

            return ListaCategories;
        }

        public void Insertar(CategoriesDto Entity)
        {
            try
            {
                Category Category = new Category();
                Category.CategoryID = Entity.CategoryID;
                Category.CategoryName = Entity.CategoryName;
                Category.Description = Entity.Description;
                
                NorthwindEntities.Categories.Add(Category);
                NorthwindEntities.SaveChanges();

                Entity.CategoryID = Category.CategoryID;
            }
            catch (Exception E)
            {
                throw new NothwindException("Categories Framework - Insertar: " +
                    E.Message, E);
            }
        }

        public void Actualizar(CategoriesDto Entity)
        {
            try
            {
                Category Category = NorthwindEntities.Categories.Single(
                    C => C.CategoryID == Entity.CategoryID);
                Category.CategoryName = Entity.CategoryName;
                Category.Description = Entity.Description;

                NorthwindEntities.SaveChanges();
            }
            catch (Exception E)
            {
                throw new NothwindException("Categories Framework - Actualizar: " +
                    E.Message, E);
            }
        }

        public void Eliminar(int Id)
        {
            try
            {
                Category Category = NorthwindEntities.Categories.Single(
                    C => C.CategoryID == Id);
                NorthwindEntities.Categories.Remove(Category);
                NorthwindEntities.SaveChanges();
            }
            catch (Exception E)
            {

                throw new NothwindException("Categories Framework - Eliminar: " +
                    E.Message, E);
            }
        }

        public CategoriesDto Obtener(int Id)
        {
            CategoriesDto CategoriesDto = new CategoriesDto();
            try
            {
                Category Category = NorthwindEntities.Categories.Single(
                    C => C.CategoryID == Id);
                if (Category != null)
                {
                    CategoriesDto.CategoryID = Category.CategoryID;
                    CategoriesDto.CategoryName = Category.CategoryName;
                    CategoriesDto.Description = Category.Description;
                }
            }
            catch (Exception E)
            {
                throw new NothwindException("Categories Framework - Obtener: " +
                    E.Message, E);
            }
            return CategoriesDto;
        }

        public List<CategoriesDto> Listar()
        {
            List<CategoriesDto> ListaCategoriesDto = new List<CategoriesDto>();
            try
            {
                IEnumerable<Category> ListaCategories = NorthwindEntities.Categories.ToList();
                foreach (Category Category in ListaCategories)
                {
                    CategoriesDto CategoriesDto = new CategoriesDto();
                    CategoriesDto.CategoryID = Category.CategoryID;
                    CategoriesDto.CategoryName = Category.CategoryName.ToUpper();
                    CategoriesDto.Description = Category.Description;
                    ListaCategoriesDto.Add(CategoriesDto);
                }
            }
            catch (Exception E)
            {
                throw new NothwindException("Categories Framework - Listar: " +
                    E.Message, E);
            }
            return ListaCategoriesDto;
        }
    }
}
