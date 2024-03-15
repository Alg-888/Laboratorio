using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa tu año de nacimiento: ");
        int birthYear = int.Parse(Console.ReadLine());

        int age = CalculateAge(birthYear);
        Console.WriteLine($"Tu edad es: {age} años");
    }

    static int CalculateAge(int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        if (DateTime.Now < new DateTime(currentYear, birthYear, 1))
        {
            age--;
        }

        return age;
    }
}

