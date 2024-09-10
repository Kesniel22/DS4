using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EstructuraRepetitivaWhile
{

    class Program
    {
        static void Main(string[] args)
        {
            int fac = 1, n;
            string linea;
            Console.Write("Ingrese un muero entero: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for (int i = 1; 1 <= n; i++)
            {
                fac = fac * i;
            }
            Console.Write("Lo factorial es: " + fac);
            Console.ReadKey();
        }
    }
}