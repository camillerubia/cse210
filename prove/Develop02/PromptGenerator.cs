using System;
using System.IO;
using System.Collections.Generic;

// Responsibilities:
//  - read prompts from a file
//  - contains list of prompts
//  - randomizes and returns the random prompt

public class PromptGenerator
{
    public string _randomPrompt;
    // Read from file
    public string[] _promptList = System.IO.File.ReadAllLines("prompts.csv");
    
    public string RandomPrompt()
    {
        Random rnd = new Random();

        // Get a random question from the list
        _randomPrompt = _promptList[rnd.Next(_promptList.Length)];
        return _randomPrompt;
    }
}