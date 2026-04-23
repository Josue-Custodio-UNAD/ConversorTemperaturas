using System;

class NumeroPositivoNegativo
{
    static void Main2()
    {
        Console.Write("Ingresa un numero: ");
        string texto = Console.ReadLine();

        if (!double.TryParse(texto, out double numero))
        {
            Console.WriteLine("Error: Debes ingresar un numero valido.");
            return;
        }

        if (numero > 0)
        {
            Console.WriteLine("El numero es positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El numero es negativo.");
        }
        else
        {
            Console.WriteLine("El numero es cero.");
        }
    }
}