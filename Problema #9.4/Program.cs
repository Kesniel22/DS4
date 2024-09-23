using System;
class Program
{
    static void Main()
    {
        Aleatorios aleatorios = new Aleatorios();

        // Ejemplo de uso del método para generar un número entre dos números
        int numero = aleatorios.GenerarNumeroEntre(1, 10);
        Console.WriteLine($"Número aleatorio entre 1 y 10: {numero}");

        // Ejemplo de uso del método para generar un arreglo de números aleatorios
        int[] arreglo = aleatorios.GenerarArregloNumerosEntre(5, 15, 5);
        Console.WriteLine("Arreglo de números aleatorios entre 5 y 15:");
        foreach (int num in arreglo)
        {
            Console.WriteLine(num);
        }
    }
}