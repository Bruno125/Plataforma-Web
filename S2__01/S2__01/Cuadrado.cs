using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2__01
{
    class Cuadrado : Cuadrilatero
    {
        double lado;

        public double Lado
        {
            get
            {
                return this.lado;
            }
            set
            {
                this.lado = value;
            }
        }

        public override double CalcularArea()
        {
            return lado;
        }

        public override double CalcularPerimetro()
        {
            return (4 * lado);
        }
    }
}
