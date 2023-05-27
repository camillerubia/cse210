using System;
using System.Collections.Generic;

public class Separator
{
    // A local field to store the book from the splitted string.
    private string _book;
    // A local field to store the chapter from the splitted string.
    private string _chapter;
    // A local field to store the verse from the splitted string.
    private string _verse;
    // A local field to store the text from the splitted string.
    private string _text;
    // A local field to store the end verse from the splitted string.
    private string _endVerse;
    // A field to store the instantiation of the Reference class.
    private string _reference;
    
    // Constructor Responsibilities:
    // - splits the passed scripture passage from the Passage class and passes the
    // separated data to respective classes.
    public void Separate(string line)
    {
        List<string> verseList = line.Split("| ").ToList();
    
        // Checks the count of the splitted string and instantiates the Reference class 
        // to get the reference and pass appropriate data.
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
        
        // Instantiates the Scripture class and passes on the reference from the Reference Class
        // and the text.
        Scripture scripture = new Scripture(_reference, _text);
    }
}