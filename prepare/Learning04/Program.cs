using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Learning04 World!");
        Console.WriteLine("Inheritance\n");

        Assignment assignment = new Assignment("Nica Rubia", "C#");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssign = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssign.GetSummary());
        Console.WriteLine(mathAssign.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writeAssign = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writeAssign.GetSummary());
        Console.WriteLine(writeAssign.GetWritingInformation());
        Console.WriteLine();
    }   
}