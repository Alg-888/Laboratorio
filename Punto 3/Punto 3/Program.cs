using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el valor de r (radio): ");
        double r = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el valor de θ (ángulo en radianes): ");
        double t = double.Parse(Console.ReadLine());

        double x = r * Math.Cos(t);
        double y = r * Math.Sin(t);

        Console.WriteLine($"Las coordenadas rectangulares son: x = {x}, y = {y}");
    }
}
