using System;

class ConversionTemperatura
{
    static void Main()
    {
        Console.WriteLine("Conversion de Temperatura");
        Console.WriteLine("1 - Celsius a Fahrenheit");
        Console.WriteLine("2 - Fahrenheit a Celsius");
        Console.Write("Elige una opcion: ");

        string opcionTexto = Console.ReadLine();

        if (!int.TryParse(opcionTexto, out int opcion))
        {
            Console.WriteLine("Debes ingresar un numero valido");
            return;
        }

        if (opcion != 1 && opcion != 2)
        {
            Console.WriteLine("Opcion invalida. Elige 1 o 2");
            return;
        }

        Console.Write("Ingres la temperatura a convertir: ");
        string tempTexto = Console.ReadLine();

        if (!double.TryParse(tempTexto, out double temperatura))
        {
            Console.WriteLine("La temperatura debe ser un numero valido");
            return;
        }

        switch (opcion)
        {
            case 1:
                double fahrenheit = (temperatura * 9.0 / 5.0) + 32;
                Console.WriteLine($"{temperatura} Celsius = {fahrenheit} Fahrenheit");
                break;

            case 2:
                double celsius = (temperatura - 32) * 5.0 / 9.0;
                Console.WriteLine($"{temperatura} Fahrenheit = {celsius} Celsius");
                break;
        }
    }
}