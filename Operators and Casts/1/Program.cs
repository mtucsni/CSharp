using System;

public class Rational
{
    public int Numerator { get; private set; }
    public int Denominator { get; private set; }

    public Rational(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        Numerator = numerator;
        Denominator = denominator;
    }
    public static Rational operator +(Rational a, Rational b)
    {
        int commonDenominator = a.Denominator * b.Denominator;
        int numerator1 = a.Numerator * b.Denominator;
        int numerator2 = b.Numerator * a.Denominator;

        return new Rational(numerator1 + numerator2, commonDenominator);
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }

    // Overloaded operators and other methods...

    public override bool Equals(object? obj) // Fixed for nullability warning
    {
        if (obj is Rational rational)
        {
            return this == rational;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Numerator, Denominator);
    }

    // Static Main method for demonstration
    static void Main(string[] args)
    {
        Rational r1 = new Rational(1, 2);
        Rational r2 = new Rational(3, 4);

        Console.WriteLine($"Rational 1: {r1}");
        Console.WriteLine($"Rational 2: {r2}");

        // Demonstrate some operations
        Rational sum = r1 + r2;
        Console.WriteLine($"Sum: {sum}");

        // Other operations...
    }
}

// Implement the overloaded operators (+, -, *, /, <, >, >=,<=,==,!=)...
