using System;
using System.Collections.Generic;

class Aleatorios
{
    private Random random;

    // Constructor para inicializar el objeto Random
    public Aleatorios()
    {
        random = new Random();
    }

    // Método para generar un número aleatorio entre dos números dados (inclusive)
    public int GenerarNumeroEntre(int min, int max)
    {
        return random.Next(min, max + 1);
    }

    // Método para generar un arreglo de números no repetidos entre dos números dados
    public int[] GenerarArregloNumerosNoRepetidos(int min, int max, int cantidad)
    {
        if (cantidad > (max - min + 1))
        {
            throw new ArgumentException("La cantidad de números solicitados es mayor que el rango posible.");
        }

        HashSet<int> numerosGenerados = new HashSet<int>();
        while (numerosGenerados.Count < cantidad)
        {
            int numero = GenerarNumeroEntre(min, max);
            numerosGenerados.Add(numero); // HashSet no permite duplicados
        }

        return new List<int>(numerosGenerados).ToArray();
    }
}