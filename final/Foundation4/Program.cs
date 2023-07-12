using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Foundation4 World!");


        Running run = new Running(30, 3);
        run.GetSummary();

        Cycling cycle = new Cycling(30, 10);
        cycle.GetSummary();

        Swimming swim = new Swimming(30, 5);
        swim.GetSummary();
    }
}