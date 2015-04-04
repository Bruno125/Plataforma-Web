using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2__01
{
    abstract class Inmueble
    {
        String nombre;
        int metraje;
        double valorPredio;

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

        public int Metraje
        {
            get
            {
                return this.metraje;
            }
            set
            {
                this.metraje = value;
            }
        }

        public double ValorPredio
        {
            get
            {
                return this.valorPredio;
            }
            set
            {
                this.valorPredio = value;
            }
        }

        public abstract double Calcular_Impuesto();
    }
}
