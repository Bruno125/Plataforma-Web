using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importaciones
using NorthwindDao.Base;
using NorthwindEntity.Entity;

namespace NorthwindDao.Dao
{
    public interface ICategoriesDao : BaseDao<CategoriesDto,int>
    {
        //Declaro los metodos personalizados que tienen que implementar
        //los hijos
        List<string> ListarPorNombre(string Nombre);

        List<CategoriesDto> ListarPorNombreObjeto(string Nombre);
    }
}
