using System;

// Responsibilities:
//  - keeps track of the scripture reference and text
//  - can hide words
//  - get the rendered text display


public class Scripture
{
    private string _fullVerse;
    private bool _checker;
    private string _reference;
    private string _text;

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
        Console.Clear();
        _fullVerse = $"{_reference} - \"{_text}\"";
        DisplayScripture(_reference, _text);

    }

    public void DisplayScripture(string reference, string text)
    {
        if (_checker == false)
        {
            
        }
         
        Console.WriteLine();
        Console.WriteLine("Press ENTER to continue or type \"quit\" to finish:");
        KeyReader();
    }

    private void KeyReader()
    {
        ConsoleKeyInfo keyPressed = Console.ReadKey();

        if (keyPressed.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Word word = new Word(_text);
            _text = word._finalVerse;
            _checker = true;
            _fullVerse = $"{_reference} - \"{_text}\""; 
            Console.WriteLine(_fullVerse);

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