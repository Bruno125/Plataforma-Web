using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace NorthWindDAO.Base
{
    interface BaseDao<E,ID>
    {
        void Insertar(E Entity);
        void Actualizar(E Entity);
        void Eliminar(ID id);
        E Obtener(ID id);
        DataTable Listar();
    }
}
