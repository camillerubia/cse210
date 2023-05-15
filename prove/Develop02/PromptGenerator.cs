using System;
using System.IO;
using System.Collections.Generic;

// Responsibilities:
//  - read prompts from a file
//  - contains list of prompts
//  - randomizes and returns the random prompt

public class PromptGenerator
{
    // A blank field that will be storing a single prompt from the randomizer.
    public string _randomPrompt;
    // Read from the predestined file then stores it into an array.
    public string[] _promptList = System.IO.File.ReadAllLines("prompts.csv");
    
    // A method that randomizes from the list of prompts and returns a single prompt.
    public string RandomPrompt()
    {
        // Instantiates the Random class and stores it into the rnd variable.
        Random rnd = new Random();

        // Get a random question from the list
        _randomPrompt = _promptList[rnd.Next(_promptList.Length)];

        // Returns the random prompt.
        return _randomPrompt;
    }
}