using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Console.WriteLine("Inheritance");

        // Assignment assignment = new Assignment("Nica Rubia", "C#");
        // Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssign = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssign.GetSummary());
        Console.WriteLine(mathAssign.GetHomeworkList());
    }
}