using System;

// Responsibilities:
//  - keeps track of the book, chapter and verse information.

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _text;
    private string _fullVerse;

    public Reference(string singleVerse)
    {

    }

    public Reference(string firstVerse, string secondVerse)
    {

    }

    public string FullVerse()
    {
        return _fullVerse;
    }
}    