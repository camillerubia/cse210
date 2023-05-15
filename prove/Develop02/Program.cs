using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Journal Program");
        Console.WriteLine();

        // Instantiates the Journal Class and stores it in the journal variable.
        Journal journal = new Journal();
        // Calls the Menu method from the Journal Class.
        journal.Menu();
    }
}

// STRETCH

// *** Journal Class ***
// - Added an error catcher in the Journal Class (when the user inputs a string instead of 
    // an int, and if the user wants to load and display a non-journal file)
// - Customized the quit option and asks the user for confirmation then loops back if the user
    // has invalid choice.
// - Has a flexible display ability for viewing CSV and non-CSV files.

// *** FileManager Class *** 
// - Added an error catcher as well in the FileManager Class (if the file doesn't exist)
// - Formatted the strings to be Excel-readable with headings. 
// - Contains different methods for  reading/saving CSV and non-CSV files.

// *** Entry Class ***
// - Saves other information such as the time which is stored with every entry in the Entry Class.