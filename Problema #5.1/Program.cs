internal class Program
{
    private int[] sueldos;

    public void Cargar()
    {
        sueldos = new int[6];
        for (int f = 1; f <= 5; f++)
        {
            Console.Write("Ingrese sueldo del operario " + f + ": ");
            String linea;
            linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea);
        }
    }
    public void Imprimir()
    {
        Console.Write("Los sueldos de los 5 operarios \n");
        for (int f = 1;f <= 5; f++)
        {
            Console.Write("["+sueldos[f]+"] ");
        }
        Console.ReadKey();
    }
    private static void Main(string[] args)
    {
        Program p = new Program();
        p.Cargar();
        p.Imprimir();
    }
}