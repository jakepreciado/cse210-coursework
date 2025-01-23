using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction defaultFraction = new Fraction();
        Console.WriteLine(defaultFraction.GetFractionString());
        Console.WriteLine(defaultFraction.GetDecimalValue());

        Fraction wholeNumberFraction = new Fraction(5);
        Console.WriteLine(wholeNumberFraction.GetFractionString());
        Console.WriteLine(wholeNumberFraction.GetDecimalValue());

        Fraction fraction1 = new Fraction(3, 4);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(1, 3);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
    }
}