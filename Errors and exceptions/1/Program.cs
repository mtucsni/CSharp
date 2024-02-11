using System;

public class Temperature
{
    public void DisplayTemperature(double temp)
    {
        if (temp == 0)
        {
            throw new TempIsZeroException("Temperature is exactly zero!");
        }

        Console.WriteLine($"The temperature is {temp} degrees.");
    }
}

public class TempIsZeroException : Exception
{
    public TempIsZeroException(string message)
        : base(message)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 }; 
        bool continueProgram = true;

        while (continueProgram)
        {
            try
            {
                Console.WriteLine("Enter the index of the array element you want to see:");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine($"Element at index {index}: {array[index]}");

                Console.WriteLine("Do you want to see another element? (yes/no)");
                continueProgram = Console.ReadLine().Trim().ToLower() == "yes";
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index is out of range. Try again.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format. Please enter a valid number.");
            }
        }
    }
}
