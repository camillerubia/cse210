using System;

public class Separator
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _text;
    private string _endVerse;
    
    public void Separate(string line)
    {
        List<string> verseList;
        verseList = line.Split(", ").ToList();

        if (verseList.Count == 4)
        {
            _book = verseList[0];
            _chapter = verseList[1];
            _verse = verseList[2];
            _text = verseList[3];
        }
        else
        {
            _book = verseList[0];
            _chapter = verseList[1];
            _verse = verseList[2];
            _endVerse = verseList[3];
            _text = verseList[4];
        }
    }

    public string GetBook()
    {
        return _book;
    }

    public string GetChapter()
    {
        return _chapter;
    }

    public string GetVerse()
    {
        return _verse;
    }

    public string GetEndVerse()
    {
        return _endVerse;
    }

    public string GetText()
    {
        return _text;
    }
}