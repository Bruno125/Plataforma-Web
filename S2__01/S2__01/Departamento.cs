using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2__01
{
    class Departamento : Inmueble
    {
        public override double Calcular_Impuesto()
        {
            return 2 * Metraje * ValorPredio;
        }
    }
}
