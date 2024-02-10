using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(AlmostOnlyLetters("She is nice.")); // Expected output: true
        Console.WriteLine(AlmostOnlyLetters("true 222."));   // Expected output: false
    }

    static bool AlmostOnlyLetters(string str)
    {
        if (!str.EndsWith('.'))
            return false;

        // Remove the period for checking the rest of the characters
        str = str.Substring(0, str.Length - 1);

        foreach (char ch in str)
        {
            if (!char.IsLetter(ch) && ch != ' ')
                return false;
        }

        return true;
    }
}
