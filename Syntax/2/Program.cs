using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficient 'a' (a != 0):");
        double a = Convert.ToDouble(Console.ReadLine());

        while (a == 0)
        {
            Console.WriteLine("Coefficient 'a' cannot be zero. Please enter a non-zero value for 'a':");
            a = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Enter the coefficient 'b':");
        double b = Convert.ToDouble(Console.ReadLine());

        // Solving the equation a*x + b = 0
        double x = -b / a;

        Console.WriteLine($"The solution of the equation {a}x + {b} = 0 is x = {x}");
    }
}
