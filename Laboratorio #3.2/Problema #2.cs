
using Laboratorio__3._2;

internal class Program
{
    private static void Main(string[] args)
    {
        CalculosMatematicos calculos = new CalculosMatematicos();
        float r;

        Console.WriteLine("Introduce el valor del Radio: ");
        r = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine(calculos.calculoArea(r));
    }
}