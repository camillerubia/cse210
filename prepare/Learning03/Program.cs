using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Console.WriteLine($"Encapsulation Learning Activity\n");

        Fraction f1 = new Fraction();
        int f1Top = f1.GetTop();
        f1Top = 1;
        f1.SetTop(f1Top);
        int f1Bottom = f1.GetBottom();
        f1Bottom = 1;
        f1.SetBottom(f1Bottom);
        string f1Fraction = f1.GetFractionString();
        double f1Decimal = f1.GetDecimalValue();
        Console.WriteLine($"#1 Fraction: {f1Fraction}, Decimal {f1Decimal}");

        Fraction f2 = new Fraction(6);
        int f2Top = f2.GetTop();
        f2Top = 1;
        f2.SetTop(f2Top);
        int f2Bottom = f2.GetBottom();
        f2Bottom = 1;
        f2.SetBottom(f2Bottom);
        string f2Fraction = f2.GetFractionString();
        double f2Decimal = f2.GetDecimalValue();
        Console.WriteLine($"#1 Fraction: {f2Fraction}, Decimal {f2Decimal}");


        Fraction f3 = new Fraction(6,7);
    }
}