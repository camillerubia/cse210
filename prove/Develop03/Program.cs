using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine("Scripture Memorizer");

        Passage passage = new Passage();
        string verse = passage._passage;
        Console.WriteLine(verse);

        string[] splitVerse = verse.Split(", ");

        string book;
        foreach (string line in splitVerse)
        {
            book = line;
            Console.WriteLine(book);
        }

        

        Reference referenceC = new Reference(verse);
        string reference = referenceC.GetReference();
        string text = referenceC.GetText(); 
        Scripture scripture = new Scripture(reference, text);



    }
}