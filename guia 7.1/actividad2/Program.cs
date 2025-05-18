using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantbudines, cantpaque, cantcajas;
            double cantmasa, masasob, budsob, cajassob, paqsob;

            Console.WriteLine("ingrese la cantidad de masa en gramos : ");
            cantmasa = Convert.ToDouble(Console.ReadLine());

            masasob = cantmasa % 55;
            cantbudines = (int)((cantmasa - masasob) / 55);
            budsob = cantbudines % 12;
            cantpaque = (int)Math.Truncate((double)cantbudines / 12);
            paqsob = cantpaque % 20;
            cantcajas = (int)Math.Truncate((double)cantpaque / 12);

            Console.WriteLine("cantidad de budines : " + cantbudines);
            Console.WriteLine("cantidad de paquetes : " + cantpaque);
            Console.WriteLine("cantidad de cajas : " + cantcajas);
            Console.WriteLine("masa sobrante : " + masasob);
            Console.WriteLine("budines sobrantes : " + budsob);
            Console.WriteLine("paquetes sobrantes : " + paqsob);

            Console.ReadKey();

        }
    }
}

