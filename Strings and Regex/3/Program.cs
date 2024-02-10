using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine(DecimalDigitInformation("This is 9")); // Expected output: "Digit 9 at position 8"
    }

    static string DecimalDigitInformation(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (Regex.IsMatch(str[i].ToString(), @"\d"))
            {
                return $"Digit {str[i]} at position {i}";
            }
        }
        return "No digit found!";
    }
}
