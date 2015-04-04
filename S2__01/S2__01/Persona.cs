using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2__01
{
    class Persona
    {
        //Atributos
        private string nombre;
        private string apellido;
        public static int edad = 18;

        //Constructor
        public Persona()
        {

        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        //Metodos

        public void CalcularDescuento(double sueldo)
        {
            Console.WriteLine("El descuento es: {0}",(sueldo*0.15));
        }

        public override string ToString()
        {
            return this.nombre + ", "+ this.apellido;
        }

        public virtual void CalcularDescuento(double sueldo, double descuento)
        {
            Console.WriteLine("El descuento es (" + descuento + "):" + (sueldo*descuento));
        }

        public void ImprimirEdad(int edad)
        {
            Console.WriteLine("La edad es: " + edad);
        }

        //Get y Set

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
    }
}
