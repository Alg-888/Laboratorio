using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el número de términos en la serie: ");
        int n = int.Parse(Console.ReadLine());

        double resultado = CalcularsumaSerie(n);
        Console.WriteLine($"La suma de la serie es: {resultado}");
    }

    static double CalcularsumaSerie(int n)
    {
        double suma = 0;
        for (int i = 0; i <= n; i++)
        {
            suma += 1.0 / Math.Pow(2, i);
        }
        return suma;
    }
}

