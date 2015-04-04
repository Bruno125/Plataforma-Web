using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2__01
{
    class Trabajador
    {
        String nombre;
        double salarioHora;
        int cantidadHoras;

        public Trabajador()
        {

        }

        public String Nombre
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

        public double SalarioHora
        {
            get
            {
                return this.salarioHora;
            }
            set
            {
                this.salarioHora = value;
            }
        }

        public int CantidadHoras
        {
            get
            {
                return this.cantidadHoras;
            }
            set
            {
                this.cantidadHoras = value;
            }
        }

        public double CalcularSueldoBruto()
        {
            return salarioHora * cantidadHoras;
        }
        public double CalcularDescuento()
        {
            return CalcularSueldoBruto() * 0.12;
        }
         public double CalcularSueldoLiquido()
        {
            return CalcularSueldoBruto() - CalcularDescuento();
        }

    }
}
