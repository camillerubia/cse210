using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Journal Program");
        Console.WriteLine();

        Journal journal = new Journal();
        journal.Menu();
    }
}
