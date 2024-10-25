using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(2);
        Fraction fraction3 = new Fraction (2,4);

        Console.WriteLine($"Fraction1 in a fraction: {fraction3.GetFractionString()}");
        Console.WriteLine($"Fraction1 in a decimal {fraction3.GetDecimalValue()}");

        
    }
}