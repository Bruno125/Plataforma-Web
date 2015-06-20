using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBusiness.Base
{
    interface BaseBusiness<E, ID>
    {
        void Insertar(E Entity);
        void Actualizar(E Entity);
        void Eliminar(ID Id);
        E Obtener(ID Id);
        List<E> Listar();

    }
}
