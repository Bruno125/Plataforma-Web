using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2__01
{
    class Casa : Inmueble
    {
        public override double Calcular_Impuesto()
        {
            return 3 * Metraje * ValorPredio;
        }



    }
}
