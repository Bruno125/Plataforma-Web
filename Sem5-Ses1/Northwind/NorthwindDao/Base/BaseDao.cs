using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDao.Base
{
    public interface BaseDao <E,ID>
    {
        void Insertar(E Entity);
        void Actualizar(E Entity);
        void Eliminar(ID Id);
        E Obtener(ID id);
        DataTable Listar();
    }
}
