using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the operation (+, -, x, /):");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result;
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case 'x':
            case 'X':
                result = num1 * num2;
                break;
            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return;
                }
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Unrecognized character");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
}
