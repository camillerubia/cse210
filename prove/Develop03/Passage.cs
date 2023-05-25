using System;
using System.Collections.Generic;

// Responsibilities:
// - read from a file.

public class Passage
{
    public string _passage = "Book1, 1, 39, This is the sample text which has been made longer, and longer.";
    private string _secondPassage = "Book2, 2, 40, 44, Second passage with a lot of verse";
    public List<string> _passageList = new List<string>{};

    // private string[] _firstPassage = {"Book1, 1, 39, This is the sample text"};
    // private string[] _secondPassage = { "Book2, 2, 40, 44, Second passage with a lot of verse"};

    // public Passage()
    // {
    // //    _passageList.AddRange(_firstPassage);
    // }
}