internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Corrio la aplica");
    }
}

sealed class ClaseBase
{
    public void test()
    {
    }

    public sealed void moreTesting()
    {
    }
}

class ClaseHijo : ClaseBase
{
}