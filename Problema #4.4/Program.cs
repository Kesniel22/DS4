using System;

namespace Lab44
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota del Estudiante");
            float score = float.Parse(Console.ReadLine());

            if (score >= 70)
            {
                Console.WriteLine();
                Console.WriteLine($"Su nota es {score} ha reprobado, debe repetir");
            }
        }
    }
}