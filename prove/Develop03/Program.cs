using System;
using System.Collections.Generic;

class Program
{
    static string book;
    static string chapter;
    static string verse;
    static string text;
    static string endVerse;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("Scripture Memorizer");

        Passage passage = new Passage();
        string line = passage._passage;
        Separator(line);
        Reference reference = new Reference(book, chapter, verse);
        string firstReference = reference.GetReference();
        Console.WriteLine(firstReference);
        // Scripture scripture = new Scripture(firstReference, text);
        


        string secondLine = passage._secondPassage;
        Separator(secondLine);
        Reference reference2 = new Reference(book, chapter, verse, endVerse);
        string secondReference = reference2.GetReference();
        Console.WriteLine(secondReference);
        // Scripture scripture2 = new Scripture(secondReference, text);


    }

    static void Separator(string line)
    {
        List<string> verseList;
        verseList = line.Split(", ").ToList();

        if (verseList.Count == 4)
        {
            book = verseList[0];
            chapter = verseList[1];
            verse = verseList[2];
            text = verseList[3];
        }
        else
        {
            book = verseList[0];
            chapter = verseList[1];
            verse = verseList[2];
            endVerse = verseList[3];
            text = verseList[4];
        }
    }
}