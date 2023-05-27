using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("Scripture Memorizer");

        Passage passage = new Passage();
        string scriptVerse = passage.GetPassage();
        Separator separator = new Separator();
        separator.Separate(scriptVerse);
    

        // string secondLine = passage._secondPassage;
        // Separator separator2 = new Separator();
        // separator2.Separate(secondLine);
    }
}