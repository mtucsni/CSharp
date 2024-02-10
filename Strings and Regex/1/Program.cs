using System;
using System.Text;

class Program
{
    static void Main()
    {
        string result = MixTwoStrings("abc", "XYZ");
        Console.WriteLine(result);  // Expected output: aXbYcZ

        result = MixTwoStrings("Hello", "World");
        Console.WriteLine(result);  // Expected output: HWoerllod
    }

    static string MixTwoStrings(string str1, string str2)
    {
        StringBuilder mixedString = new StringBuilder();
        int maxLength = Math.Max(str1.Length, str2.Length);

        for (int i = 0; i < maxLength; i++)
        {
            if (i < str1.Length)
                mixedString.Append(str1[i]);
            if (i < str2.Length)
                mixedString.Append(str2[i]);
        }

        return mixedString.ToString();
    }
}
