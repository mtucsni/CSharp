using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Number to convert:");
        int number = Convert.ToInt32(Console.ReadLine());

        string binary = Convert.ToString(number, 2);
        Console.WriteLine($"Binary: {binary}");
    }
}
