using System;

// Responsibilities:
//  - keeps track of the book, chapter and verse information.

public class Reference
{
    private string _book;
    private int _chapter;
    private string _verse;
    private string _endVerse;
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