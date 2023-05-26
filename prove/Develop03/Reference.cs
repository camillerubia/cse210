using System;

// Responsibilities:
//  - keeps track of the book, chapter and verse information.

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;
    // private string _text;
    private string _reference;
    private List<string> _referenceList = new List<string>{};

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

    private string SingleVerse()
    {
        return $"{_book} {_chapter}:{_verse}";
    }

    private string MultiVerse()
    {
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }

    public string GetReference()
    {
        if (string.IsNullOrEmpty(_endVerse))
        {
            return SingleVerse();
        }
        else
        {
            return MultiVerse();
        }
    }

    // public Reference(string singleVerse)
    // {
    //     _referenceList = singleVerse.Split(", ").ToList();
    //     _book = _referenceList[0];
    //     _chapter = _referenceList[1];
    //     _verse = _referenceList[2];
    //     _text = _referenceList[3];
    // }

    // public Reference(string firstVerse, string secondVerse)
    // {
    //     _referenceList = singleVerse.Split(", ").ToList();
    //     _book = _referenceList[0];
    //     _chapter = _referenceList[1];
    //     _verse = _referenceList[2];
    //     _text = _referenceList[3];
    // }

    // public string GetReference()
    // {
    //     _reference = $"{_book} {_chapter}:{_verse}";
    //     return _reference;
    // }

    // public string GetText()
    // {
    //     return _text;
    // }
}    