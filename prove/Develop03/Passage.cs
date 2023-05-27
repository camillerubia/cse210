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

    // Responsibilities:
    // - read from a file
    // - call the RandomPassage() method 
    public Passage()
    {
        try
        {
            // Read from the predestined file then stores it into an array.
            _passageList = System.IO.File.ReadAllLines("passages.txt").ToList();   
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