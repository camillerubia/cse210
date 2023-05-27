using System;

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