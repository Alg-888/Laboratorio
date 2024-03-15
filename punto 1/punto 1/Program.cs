using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa tu año de nacimiento: ");
        int AñoNacimiento = int.Parse(Console.ReadLine());

        int edad = CalculateAge(AñoNacimiento);
        Console.WriteLine($"Tu edad es: {edad} años");
    }

    static int CalculateAge(int AñoNacimiento)
    {
        int AñoActual = DateTime.Now.Year;
        int edad = AñoActual - AñoNacimiento;

        if (DateTime.Now < new DateTime(AñoActual, AñoNacimiento, 1))
        {
            edad--;
        }

        return edad;
    }
}

