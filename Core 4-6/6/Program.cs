using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(ToThePowerOf(2, 3)); // Expected output: 8
        Console.WriteLine(ToThePowerOf(5, 5)); // Expected output: 3125
    }

    static int ToThePowerOf(int baseNum, int exponent)
    {
        return (int)Math.Pow(baseNum, exponent);
    }
}
