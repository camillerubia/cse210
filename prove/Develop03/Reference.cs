using System;
using System.Collections.Generic;

// Responsibilities:
//  - keeps track of the book, chapter and verse information.

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;
    
    public Reference (string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference (string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

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