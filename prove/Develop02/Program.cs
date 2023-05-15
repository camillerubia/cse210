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

// STRETCH
// - Added an error catcher in the Journal Class when the user inputs a string instead of an int.
// - 