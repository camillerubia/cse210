using System;

// Exceeding Requirements
// - program have a library of scriptures to work on
// - loads from a default file then chooses 1 random scripture
// - hides 3 words at once.

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("Scripture Memorizer");

        // Instantiates the Passage Class and stores it into passage variable.
        Passage passage = new Passage();

        // calls the GetPassage() method to get the passage as string.
        string scriptVerse = passage.GetPassage();

        // Instantiates the Separator class and passes the scriptVerse to the Separate method.
        Separator separator = new Separator();
        separator.Separate(scriptVerse);
    }
}