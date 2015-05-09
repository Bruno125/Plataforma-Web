using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importaciones
using NorthwindDao.Dao.Ado;
using NorthwindDao.Dao.Framework;

namespace NorthwindBusiness.Util
{
    static class UtilBusiness
    {
        //Enumerador
        public enum Clase { Categories, Products }
        public enum TipoImplementacion { ADO, EntityFramework}

        public static Object ObtenerInstancia(Clase Clase)
        {
            Object BaseDao = null;
            TipoImplementacion TipoImplementacion = UtilBusiness.TipoImplementacion.ADO;
            switch (Clase)
            {
                case Clase.Categories:
                    if (TipoImplementacion == UtilBusiness.TipoImplementacion.ADO)
                    {
                        BaseDao = CategoriesAdo.ObtenerInstancia();
                    }
                    else if (TipoImplementacion == UtilBusiness.TipoImplementacion.EntityFramework)
                    {
                        BaseDao = CategoriesFramework.ObtenerInstancia();
                    }                   
                    break;
                case Clase.Products:
                    if (TipoImplementacion == UtilBusiness.TipoImplementacion.ADO)
                    {
                        BaseDao = ProductsAdo.ObtenerInstancia();
                    }
                    else if (TipoImplementacion == UtilBusiness.TipoImplementacion.EntityFramework)
                    {
                        BaseDao = ProductsFramework.ObtenerInstancia();
                    }                   
                    break;
            }
            return BaseDao;
        }

    }
}
