using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(IfNumberContains3(7201432)); // Expected output: true
        Console.WriteLine(IfNumberContains3(87501));   // Expected output: false
    }

    static bool IfNumberContains3(int number)
    {
        while (number > 0)
        {
            if (number % 10 == 3)
            {
                return true;
            }
            number /= 10;
        }
        return false;
    }
}
