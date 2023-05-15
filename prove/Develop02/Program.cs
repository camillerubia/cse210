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
// - Added an error catcher in the Journal (when the user inputs a string instead of an int, and
// if the user wants to load and display non-journal file)
// and FileManager Class (if the file doesn't exists)
// .
// - 