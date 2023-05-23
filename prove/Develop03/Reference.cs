using System;

// Responsibilities:
//  - keeps track of the book, chapter and verse information.

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;
    private string _text;
    private string _reference;
    private List<string> _referenceList = new List<string>{};

    public Reference(string singleVerse)
    {
        _referenceList = singleVerse.Split(", ").ToList();
        _book = _referenceList[0];
        _chapter = _referenceList[1];
        _verse = _referenceList[2];
        _text = _referenceList[3];
    }

    public Reference(string firstVerse, string secondVerse)
    {

    }

    public string GetReference()
    {
        _reference = $"{_book} {_chapter}:{_verse}";
        return _reference;
    }

    public string GetText()
    {
        return _text;
    }
}    