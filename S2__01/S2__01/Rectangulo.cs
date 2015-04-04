using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2__01
{
    class Rectangulo : Cuadrilatero
    {
        double ancho, largo;

        public double Largo
        {
            get
            {
                return this.largo;
            }
            set
            {
                this.largo = value;
            }
        }

        public double Ancho
        {
            get
            {
                return this.ancho;
            }
            set
            {
                this.ancho = value;
            }
        }

        public override double CalcularArea()
        {
            return largo * ancho;
        }

        public override double CalcularPerimetro()
        {
            return (2 * largo) + (2 * ancho);
        }
    }
}
