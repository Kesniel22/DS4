interface iTemplate
{
    public void ponerVariable(string nombre, string var);
    public void verHTML(string Template);
}

class Template : iTemplate
{
    public void ponerVariable(String nombre, string var)
    {
        Console.WriteLine("Metodo poner variable {nombre} : {var}");
    }
    public void verHTML (string template)
    {
        Console.WriteLine(template);
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Template temp1 = new Template();
        temp1.ponerVariable("var1", "Valor 1");
        temp1.ponerVariable("var2", "Valor 2");
        temp1.ponerVariable("var3", "Valor 3");
        temp1.verHTML("<br>Texto de Prueba</br>");
    }
}