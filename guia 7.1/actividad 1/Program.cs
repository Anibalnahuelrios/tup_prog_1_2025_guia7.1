using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anibal1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double monto1, monto2, monto3, monto4, porc1, porc2, porc3, porc4, montoarepartir, sumaedad;
            double edad1, edad2, edad3, edad4;

            Console.WriteLine("ingrese las edades de las niñas 1");
            edad1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese las edades de las niñas 2");
            edad2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese las edades de las niñas 3");
            edad3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese las edades de las niñas 4");
            edad4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese el monto a repartir:");
            montoarepartir = Convert.ToDouble(Console.ReadLine());

            sumaedad = (edad1 + edad2 + edad3 + edad4);

            porc1 = (edad1 * 100) / sumaedad;
            porc2 = (edad2 * 100) / sumaedad;
            porc3 = (edad3 * 100) / sumaedad;
            porc4 = (edad4 * 100) / sumaedad;

            monto1 = (porc1 * montoarepartir) / 100;
            monto2 = (porc2 * montoarepartir) / 100;
            monto3 = (porc3 * montoarepartir) / 100;
            monto4 = (porc4 * montoarepartir) / 100;

            Console.WriteLine("el monto de la niña 1 es :" + monto1);
            Console.WriteLine("el monto de la niña 2 es :" + monto2);
            Console.WriteLine("el monto de la niña 3 es :" + monto3);
            Console.WriteLine("el monto de la niña 4 es :" + monto4);

            Console.ReadKey();

        }
    }
}

