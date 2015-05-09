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
    public interface IProductsDao : BaseDao<ProductsDto, int>
    {
        
    }
}
