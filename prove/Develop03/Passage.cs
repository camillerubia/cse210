using System;
using System.Collections.Generic;

// Responsibilities:
// - read from a file.

public class Passage
{
    private string _passage;
    // public string _secondPassage = "Book2| 2| 40| 44| Second passage with a lot of verse.";
    private List<string> _passageList = new List<string>{};

    public Passage()
    {
        // Read from the predestined file then stores it into an array.
        _passageList = System.IO.File.ReadAllLines("passages.txt").ToList();   
        RandomPassage();
    }

    private string RandomPassage()
    {
        // Instantiates the Random class and stores it into the rnd variable.
        Random rnd = new Random();

        // Get a random question from the list
        _passage = _passageList[rnd.Next(_passageList.Count)];

        // Returns the random prompt.
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