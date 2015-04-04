using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2__01
{
    class X
    {
        protected virtual void Metodo01()
        {
            Console.WriteLine("X.Metodo01");
        }

        protected virtual void Metodo02()
        {
            Console.WriteLine("X.Metodo02");
        }
    }

    class Y : X
    {
        sealed protected override void Metodo01()
        {
            Console.WriteLine("Y.Metodo01");
        }

        protected override void Metodo02()
        {
            Console.WriteLine("Y.Metodo02");
        }
    }

    class Z : Y
    {
        /*protected override void Metodo01()
        {
            Console.WriteLine("Z.Metodo01");
        }*/

        protected override void Metodo02()
        {
            Console.WriteLine("Z.Metodo02");
        }
    }
}
