using System;

public class Separator
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _text;
    private string _endVerse;
    private string _reference;

    // public Separator(string verse)
    // {
    //     Separate(verse);
    // }
    
    public void Separate(string line)
    {
        List<string> verseList;
        verseList = line.Split("| ").ToList();

        if (verseList.Count == 4)
        {
            _book = verseList[0];
            _chapter = verseList[1];
            _verse = verseList[2];
            _text = verseList[3];
            Reference reference = new Reference(_book, _chapter, _verse);
            _reference = reference.GetReference();         
        }
        else
        {
            _book = verseList[0];
            _chapter = verseList[1];
            _verse = verseList[2];
            _endVerse = verseList[3];
            _text = verseList[4];
            Reference reference = new Reference(_book, _chapter, _verse, _endVerse);
            _reference = reference.GetReference();         
        }
        
        Scripture scripture = new Scripture(_reference, _text);
    }
}