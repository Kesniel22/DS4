using System;

class Program
{
    static void Main()
    {
        double lado1, lado2, lado3;

        // Ingresar los tres lados del triángulo
        Console.Write("Introduce el lado 1: ");
        lado1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el lado 2: ");
        lado2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Introduce el lado 3: ");
        lado3 = Convert.ToDouble(Console.ReadLine());

        // Verificar si los lados forman un triángulo
        if (EsTriangulo(lado1, lado2, lado3))
        {
            // Determinar el tipo de triángulo
            string tipoTriangulo = TipoDeTriangulo(lado1, lado2, lado3);
            Console.WriteLine($"Los lados ingresados forman un triángulo {tipoTriangulo}.");
        }
        else
        {
            Console.WriteLine("Los lados ingresados no forman un triángulo.");
        }
    }

    // Función para verificar si los lados forman un triángulo
    static bool EsTriangulo(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    // Función para determinar el tipo de triángulo
    static string TipoDeTriangulo(double a, double b, double c)
    {
        if (a == b && b == c)
        {
            return "equilátero";
        }
        else if (a == b || a == c || b == c)
        {
            return "isósceles";
        }
        else
        {
            return "escaleno";
        }
    }
}
