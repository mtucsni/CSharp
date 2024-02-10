using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter numbers (end with a number that ends in two zeros):");

        while (true)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            numbers.Add(number);

            // Check if the number ends in two zeros
            if (number % 100 == 0)
            {
                break;
            }
        }

        Console.WriteLine("Entered numbers:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
