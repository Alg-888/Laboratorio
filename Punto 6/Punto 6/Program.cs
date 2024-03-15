using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el número de términos en la serie: ");
        int n = int.Parse(Console.ReadLine());

        double result = CalculateSeriesSum(n);
        Console.WriteLine($"La suma de la serie es: {result}");
    }

    static double CalculateSeriesSum(int n)
    {
        double sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum += 1.0 / Math.Pow(2, i);
        }
        return sum;
    }
}

