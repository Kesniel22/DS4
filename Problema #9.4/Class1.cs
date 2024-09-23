using System;
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
        return random.Next(min, max + 1); // max + 1 porque el rango en Next es exclusivo del máximo
    }

    // Método para generar un arreglo de números aleatorios entre dos números dados
    public int[] GenerarArregloNumerosEntre(int min, int max, int cantidad)
    {
        int[] arreglo = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            arreglo[i] = GenerarNumeroEntre(min, max);
        }
        return arreglo;
    }
}