using System;

class Program
{
    static void Main()
    {
        char choice;
        do
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("a) Dividir");
            Console.WriteLine("b) Obtener cubo");
            Console.WriteLine("c) Cálculo de IMC (Índice de Masa Corporal)");
            Console.WriteLine("d) Salir");
            Console.Write("Elige una opción: ");
            choice = char.ToLower(Console.ReadKey().KeyChar);

            switch (choice)
            {
                case 'a':
                    Dividir();
                    break;
                case 'b':
                    ObtenerCubo();
                    break;
                case 'c':
                    CalcularIMC();
                    break;
                case 'd':
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intenta nuevamente.");
                    break;
            }
        } while (choice != 'd');
    }

    static void Dividir()
    {
        Console.Write("Ingresa el dividendo: ");
        double dividendo = double.Parse(Console.ReadLine());
        Console.Write("Ingresa el divisor: ");
        double divisor = double.Parse(Console.ReadLine());

        double resultado = dividendo / divisor;
        Console.WriteLine($"Resultado de la división: {resultado}");
    }

    static void ObtenerCubo()
    {
        Console.Write("Ingresa un número para obtener su cubo: ");
        double numero = double.Parse(Console.ReadLine());

        double cubo = Math.Pow(numero, 3);
        Console.WriteLine($"El cubo de {numero} es: {cubo}");
    }

    static void CalcularIMC()
    {
        Console.Write("Ingresa tu peso en kg: ");
        double peso = double.Parse(Console.ReadLine());
        Console.Write("Ingresa tu altura en metros: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / Math.Pow(altura, 2);
        Console.WriteLine($"Tu IMC es: {imc:F2}");
    }
}
