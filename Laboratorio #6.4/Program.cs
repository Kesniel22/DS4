﻿internal class Program
{
    static void checkAge(int age)
    {
        if (age < 18) 
        {
            throw new ArithmeticException("Acceso negado - No cumple criterio de edad");
        }
        else 
        {
            Console.WriteLine("Acceso Concedido");
        }

    }
    private static void Main(string[] args)
    {
        checkAge(15);
    }
}