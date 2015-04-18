using NorthwindDao.Base;
using NorthwindEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDao.Dao
{
    public class ProductDao : Conexion, BaseDao<Products,int>
    {

        public void Insertar(Products Entity)
        {
            throw new NotImplementedException();
        }

        public void Actualizar(Products Entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int Id)
        {
            throw new NotImplementedException();
        }

        public Products Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public System.Data.DataTable Listar()
        {
            throw new NotImplementedException();
        }
    }
}
