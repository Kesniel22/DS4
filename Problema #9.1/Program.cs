using System;

class Program
{
    static void Main()
    {
        decimal precio;
        string formaPago;
        string numeroTarjeta = "";

        do
        {
            Console.Write("Introduce el precio del producto (valor positivo): ");
        } while (!decimal.TryParse(Console.ReadLine(), out precio) || precio <= 0);

        do
        {
            Console.Write("Introduce la forma de pago (efectivo o tarjeta): ");
            formaPago = Console.ReadLine()?.ToLower();
        } while (formaPago != "efectivo" && formaPago != "tarjeta");

        if (formaPago == "tarjeta")
        {
            do
            {
                Console.Write("Introduce el número de la tarjeta (16 dígitos): ");
                numeroTarjeta = Console.ReadLine();
            } while (numeroTarjeta.Length != 16 || !ulong.TryParse(numeroTarjeta, out _));
        }

        // Mostrar los detalles ingresados
        Console.WriteLine("\nDetalles de la compra:");
        Console.WriteLine("Precio del producto: $" + precio);
        Console.WriteLine("Forma de pago: " + (formaPago == "tarjeta" ? "Tarjeta" : "Efectivo"));
        if (formaPago == "tarjeta")
        {
            Console.WriteLine("Número de tarjeta: " + numeroTarjeta);
        }
    }
}
