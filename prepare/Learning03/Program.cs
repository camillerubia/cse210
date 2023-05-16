using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Console.WriteLine($"Encapsulation Learning Activity\n");

        Fraction f1 = new Fraction();
        Console.WriteLine($"Fraction #1: {f1.GetFractionString()}");
        Console.WriteLine($"Decimal #1: {f1.GetDecimalValue()}\n");

        Fraction f2 = new Fraction(5);
        Console.WriteLine($"Fraction #2: {f2.GetFractionString()}");
        Console.WriteLine($"Decimal #2: {f2.GetDecimalValue()}\n");

        Fraction f3 = new Fraction(3,4);
        Console.WriteLine($"Fraction #3: {f3.GetFractionString()}");
        Console.WriteLine($"Decimal #3: {f3.GetDecimalValue()}\n");

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine($"Fraction #4: {f4.GetFractionString()}");
        Console.WriteLine($"Decimal #4: {f4.GetDecimalValue()}\n");
    }
}