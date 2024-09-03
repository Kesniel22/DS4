using Laboratorio__3._3;

internal class Program
{
    private static void Main(string[] args)
    {
        CalculosMatematicos calculos = new CalculosMatematicos();
        float ancho, alto;

        Console.WriteLine("Ingrese el valor del Ancho: ");
        ancho = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Ingrese el valor del Alto: ");
        alto = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine(calculos.calcularPerimetro(ancho, alto));
    }
}