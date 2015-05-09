using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBussiness.Base
{
    interface BaseBusiness<E,ID>
    {
        void Insertar(E Entity);
        void Actualizar(E Entity);
        void Eliminar(ID id);
        E Obtener(ID id);
        DataTable Listar();
    }
}
