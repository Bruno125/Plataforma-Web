using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2__01
{
    abstract class ACalculadora
    {
        public double Dividir(double a, double b)
        {
            return a / b;
        }

        public abstract double Potencia(double a, double b);
    }
}
