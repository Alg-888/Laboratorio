using System;

class Program
{
    static void Main()
    {
        char opcion;
        do
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("a) Dividir");
            Console.WriteLine("b) Obtener cubo");
            Console.WriteLine("c) Cálculo de IMC (Índice de Masa Corporal)");
            Console.WriteLine("d) Salir");
            Console.Write("Elige una opción: ");
            opcion = char.ToLower(Console.ReadKey().KeyChar);

            switch (opcion)
            {
                case 'a':
                    // Lógica para la opción 'a'
                    Console.WriteLine("Seleccionaste Dividir");
                    break;
                case 'b':
                    // Lógica para la opción 'b'
                    Console.WriteLine("Seleccionaste Obtener cubo");
                    break;
                case 'c':
                    // Lógica para la opción 'c'
                    Console.WriteLine("Seleccionaste Cálculo de IMC");
                    break;
                case 'd':
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intenta nuevamente.");
                    break;
            }
        } while (opcion != 'd');
    }
}
