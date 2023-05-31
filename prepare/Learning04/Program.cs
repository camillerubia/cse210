using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Console.WriteLine("Inheritance");

        Assignment assignment = new Assignment("Nica", "C#");
        Console.WriteLine(assignment.GetSummary());
    }
}