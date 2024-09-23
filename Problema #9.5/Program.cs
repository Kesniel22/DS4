using System;
class Program
{
    static void Main()
    {
        Aleatorios aleatorios = new Aleatorios();

        // Generar un arreglo de números no repetidos entre 1 y 20
        int[] arregloNoRepetidos = aleatorios.GenerarArregloNumerosNoRepetidos(1, 20, 10);

        Console.WriteLine("Arreglo de números aleatorios no repetidos entre 1 y 20:");
        foreach (int num in arregloNoRepetidos)
        {
            Console.WriteLine(num);
        }
    }
}