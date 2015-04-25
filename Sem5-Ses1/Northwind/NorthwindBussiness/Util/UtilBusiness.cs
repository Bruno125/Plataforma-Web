using NorthwindDao.Dao;
using NorthwindDao.Dao.Ado;
using NorthwindDao.Dao.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBussiness.Util
{
    static class UtilBusiness
    {
        //Enumaradores
        public enum Clase { Categories,Products}
        public enum TipoImplementacion { Ado,EntityFramework}

        public static Object ObtenerInstancia(Clase Clase)
        {
            Object BaseDao = null;
            TipoImplementacion TipoImplementacion = TipoImplementacion.EntityFramework;
            switch (Clase)
            {
                case Clase.Categories:
                    if (TipoImplementacion == TipoImplementacion.Ado)
                        BaseDao = CategoriesAdo.ObtenerInstancia();
                    else if (TipoImplementacion == TipoImplementacion.EntityFramework)
                        BaseDao = CategoriesFramework.ObtenerInstancia();
                    else
                        BaseDao = CategoriesAdo.ObtenerInstancia();
                    break;
                case Clase.Products:
                    if (TipoImplementacion == TipoImplementacion.Ado)
                        BaseDao = CategoriesAdo.ObtenerInstancia();
                    break;
            }

            return BaseDao;
        }
    }
}
