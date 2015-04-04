using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2__01
{
    class Empleado : Persona
    {
        public override void CalcularDescuento(double sueldo, double descuento)
        {
            Console.WriteLine("El descuento del empleado es (" + descuento + "):" + (sueldo * descuento));
            //base.CalcularDescuento(sueldo, descuento);
        }

        public new void ImprimirEdad(int edad)
        {
            Console.WriteLine("La edad del empleado es: " + edad);
        }

    }


}
