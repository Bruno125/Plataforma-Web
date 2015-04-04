using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2__01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Persona p = new Persona("a");
            //Invocando GET
            p.Nombre = "Bruno";
            p.Apellido = "Aybar";
            //LLamando set
            Console.WriteLine("Nombre: {0}",p.Nombre);
            Console.WriteLine("Apellido: {0}", p.Apellido);
            Console.WriteLine("Edad: {0}", Persona.edad);
            //Llamando al ToString
            Console.WriteLine("ToString: {0}", p.ToString());

            //Llamar al metodo calcularDescuento
            p.CalcularDescuento(500, 0.5);
            //Creando objeto Persona que se comporta como empleado
            Persona p2 = new Empleado();
            p2.CalcularDescuento(500, 0.5);
            //Creando objeto empleado
            Empleado e = new Empleado();
            e.CalcularDescuento(1000, 0.5);
            //Imprimir la edad
            p.ImprimirEdad(18);
            p2.ImprimirEdad(18);
            e.ImprimirEdad(18);
            //Creando una interface
            Calculadora calc = new Calculadora();
            Console.WriteLine("3 + 2 = " + calc.Sumar(3, 2));
            Console.WriteLine("10 - 5 = " + calc.Restar(10, 5));
            Console.WriteLine("3 * 2 = " + calc.Multiplicar(3, 2));
            Console.WriteLine("10 / 5 = " + calc.Dividir(10, 5));
            Console.WriteLine("3 ^ 2 = " + calc.Potencia(3, 2));
            Console.ReadLine();*/


            /*EJERCICIO 1
             * Trabajador t = new Trabajador();
            Console.WriteLine("Ingrese el nombre del trabajador: ");
            t.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el salario por hora del trabajador: ");
            t.SalarioHora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de horas del trabajador: ");
            t.CantidadHoras = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Sueldo bruto: " + t.CalcularSueldoBruto());
            Console.WriteLine("Descuento: " + t.CalcularDescuento());
            Console.WriteLine("Sueldo Liquido: " + t.CalcularSueldoLiquido());

            Console.ReadLine();*/


            /*EJERCICIO 2
            Inmueble casa = new Casa();
            Console.WriteLine("Ingrese el nombre de la casa: ");
            casa.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el metraje de la casa: ");
            casa.Metraje = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor predial de la casa: ");
            casa.ValorPredio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Impuesto casa: " + casa.Calcular_Impuesto());


            Inmueble depa = new Departamento();
            Console.WriteLine("Ingrese el nombre de la depa: ");
            depa.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el metraje de la depa: ");
            depa.Metraje = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor predial de la depa: ");
            depa.ValorPredio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Impuesto casa: " + depa.Calcular_Impuesto());

            Inmueble terreno = new Terreno();
            Console.WriteLine("Ingrese el nombre de la terreno: ");
            terreno.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el metraje de la terreno: ");
            terreno.Metraje = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor predial de la terreno: ");
            terreno.ValorPredio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Impuesto casa: " + terreno.Calcular_Impuesto());*/

            Cuadrado cuadrado = new Cuadrado();
            cuadrado.Lado = 10;
            Console.WriteLine("Area cuadrado: " + cuadrado.CalcularArea());
            Console.WriteLine("Perimetro cuadrado: " + cuadrado.CalcularPerimetro());

            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Ancho = 50;
            rectangulo.Largo = 10;
            Console.WriteLine("Rectangulo cuadrado: " + rectangulo.CalcularArea());
            Console.WriteLine("Rectangulo cuadrado: " + rectangulo.CalcularPerimetro());
            Console.ReadLine();
        }
    }
}
