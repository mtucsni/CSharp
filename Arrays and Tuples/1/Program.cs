using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input the number of elements to be stored in the array:");
        int numberOfElements = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[numberOfElements];
        int sum = 0;

        for (int i = 0; i < numberOfElements; i++)
        {
            Console.WriteLine($"Input element - {i}:");
            array[i] = Convert.ToInt32(Console.ReadLine());
            sum += array[i];
        }

        Console.WriteLine($"Sum of all elements stored in the array is: {sum}");
    }
}
