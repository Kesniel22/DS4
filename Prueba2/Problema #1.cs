using Laboratorio_;

internal class Program
{
    private static void Main(string[] args)
    {
        CalculosMatematicos calculos = new CalculosMatematicos();
        int a, b;

        Console.Write("Introduce el número A: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el número B: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(calculos.Calcular(a, b));
    }
}