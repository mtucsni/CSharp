using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input the number of elements to be stored in the array:");
        int numberOfElements = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[numberOfElements];
        List<int> evenNumbers = new List<int>();
        List<int> oddNumbers = new List<int>();

        for (int i = 0; i < numberOfElements; i++)
        {
            Console.WriteLine($"Input element - {i}:");
            array[i] = Convert.ToInt32(Console.ReadLine());

            if (array[i] % 2 == 0)
                evenNumbers.Add(array[i]);
            else
                oddNumbers.Add(array[i]);
        }

        Console.WriteLine("The Even elements are:");
        foreach (var num in evenNumbers)
            Console.Write(num + " ");
        Console.WriteLine();

        Console.WriteLine("The Odd elements are:");
        foreach (var num in oddNumbers)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}
