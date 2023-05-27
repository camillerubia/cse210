using System;
using System.Collections.Generic;

// Responsibilities:
// - read from a file.

public class Passage
{
    private string _passage;
    private List<string> _passageList = new List<string>{};

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
            // Displays an error message if the file is not found within the containind folder.
            Console.WriteLine($"File not existing.\n");
        }
    }

    private string RandomPassage()
    {
        // Instantiates the Random class and stores it into the rnd variable.
        Random rnd = new Random();
        
            // Get a random line from the list
            _passage = _passageList[rnd.Next(_passageList.Count)];
        
        // Returns the random line.
        return _passage;
    }

    public string GetPassage()
    {
        return _passage;
    }

    public override string ToString()
    {
        return _passage;
    }
}