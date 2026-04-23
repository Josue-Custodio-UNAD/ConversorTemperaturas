using System;

class MayorDeEdad
{
    static void Main1()
    {
        Console.Write("Ingresa tu edad: ");
        string texto = Console.ReadLine();

        if (!int.TryParse(texto, out int edad))
        {
            Console.WriteLine("Error: Debes ingresar un numero valido.");
            return;
        }

        if (edad < 0)
        {
            Console.WriteLine("Error: La edad no puede ser negativa.");
            return;
        }

        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad.");
        }
        else
        {
            Console.WriteLine("Eres menor de edad.");
        }
    }
}