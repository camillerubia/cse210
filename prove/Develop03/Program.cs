using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("Scripture Memorizer");

        Passage passage = new Passage();
        string line = passage._passage;
        Separator separator = new Separator();
        separator.Separate(line);

        string book = separator.GetBook();
        string chapter = separator.GetChapter();
        string verse = separator.GetVerse();
        string text = separator.GetText();

        Reference reference = new Reference(book, chapter, verse);
        string firstReference = reference.GetReference();
        // Console.WriteLine(text);
        // Console.WriteLine($"{firstReference} - \"{text}\" ");
        Scripture scripture = new Scripture(firstReference, text);
     


        string secondLine = passage._secondPassage;
        Separator separator2 = new Separator();
        separator2.Separate(secondLine);
        
        string book2 = separator2.GetBook();
        string chapter2 = separator2.GetChapter();
        string verse2 = separator2.GetVerse();
        string endVerse = separator2.GetEndVerse();
        string text2 = separator2.GetText();

        Reference reference2 = new Reference(book2, chapter2, verse2, endVerse);
        string secondReference = reference2.GetReference();
        
        // Console.WriteLine("Second scripture");
        // Console.WriteLine($"{secondReference} - \"{text2}\" ");
        // Scripture scripture2 = new Scripture(secondReference, text2);
    }
}