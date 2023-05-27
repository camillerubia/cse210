using System;
using System.Collections.Generic;

// Responsibilities:
// - read from a file.
// - get a random scripture passage and return it.

public class Passage
{
    // A field to store the random passage.
    private string _passage;
    // A list to store the data from the file.
    private List<string> _passageList = new List<string>{};
    //  A field to store the user's filename.
    private string _filename;
    // A field to store the user input.
    private string _userInput;

    // Responsibilities:
    // - read from a file
    // - call the RandomPassage() method 
    public Passage()
    {
        ConfirmFile();
    }

    // Asks the user if they want to load from a file or not.
    private void ConfirmFile()
    {
        // Initiates a do-while loop to continue if the user answers other than 'y' or 'n'.
        do
        {
            Console.Write("Do you want to read from a file? (y or n): ");
            _userInput = Console.ReadLine();
            Console.WriteLine("Please make sure it is a txt with a `|` delimiter.");
        
            if (_userInput == "y")
            {
                Console.Write("What is the filename? ");
                _filename = Console.ReadLine();
                break;
            }
            else if (_userInput == "n")
            {
                // When user doesn't want to load from a file, the default file loads.
                _filename = "passages.txt";
                break;
            }
        } while (_userInput != "y" || _userInput != "n");
        
        // Calls the method to read from the default or the provided file.
        ReadFromFile();
    }

    private void ReadFromFile()
    {
        try
        {
            // Read from the predestined file then stores it into an array.
            _passageList = System.IO.File.ReadAllLines(_filename).ToList();   
            RandomPassage();
        }
        catch (FileNotFoundException)
        {
            // Displays an error message if the file is not found within the containing folder.
            Console.WriteLine($"File not existing.\n");
        }
    }

    // Responsibilities:
    // - randomize one passage from the list
    // - return the single string passage.
    private string RandomPassage()
    {
        // Instantiates the Random class and stores it into the rnd variable.
        Random rnd = new Random();
        
        // Get a random line from the list
        _passage = _passageList[rnd.Next(_passageList.Count)];
        
        // Returns the random line.
        return _passage;
    }

    // Responsibilities:
    // - provides access to the _passage field outside of the class.
    public string GetPassage()
    {
        return _passage;
    }

    // Overrides the ToString() method for checking/debugging.
    public override string ToString()
    {
        return _passage;
    }
}