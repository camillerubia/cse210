using System;
using System.Collections.Generic;

// Responsibilities:
//  - keeps track of the book, chapter and verse information.

public class Reference
{
    // A field to store the book from the passed data in the constructor.
    private string _book;
    // A field to store the chapter from the passed data in the constructor.
    private string _chapter;
    // A field to store the verse from the passed data in the constructor.
    private string _verse;
    // A field to store the end verse from the passed data in the constructor.
    private string _endVerse;

    // Constructor Responsibilities:
    // -  receives and stores the data from the parameters for local use.
    public Reference (string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Handles the reference with an end verse.
    public Reference (string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // A method that formats the collected data according to the available data.
    public string GetReference()
    {
        if (_endVerse == null)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}    