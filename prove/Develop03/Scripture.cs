using System;

// Responsibilities:
//  - keeps track of the scripture reference and text
//  - can hide words
//  - get the rendered text display


public class Scripture
{
    private string _fullVerse;
    private bool _checker;

    public Scripture(string reference, string text)
    {
       _fullVerse = $"{reference} - \"{text}\"";
       Console.WriteLine(_fullVerse);
    }

    public void DisplayScripture()
    // public void DisplayScripture(List<string> list)
    {
        Console.Write("What should you do? ");
        KeyReader();
    }

    private void KeyReader()
    {
        ConsoleKeyInfo keyPressed = Console.ReadKey();

        if (keyPressed.Key == ConsoleKey.Enter)
        {
            _checker = true;
            Console.Clear();
            Console.WriteLine("Console Cleared");
        }
        else if (keyPressed.Key != ConsoleKey.Enter)
        {
            Console.WriteLine("Please type quit instead.");
        }
    }

    private bool ConfirmHide(List<string> newList)
    {
    foreach (string item in newList)
        {
            if (item.Contains("hide"))
            {
                return _checker = true; // Hide
            }
        }

        return _checker = false; // Don't hide
    }

}