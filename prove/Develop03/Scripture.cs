using System;
using System.Collections.Generic;

// Responsibilities:
//  - keeps track of the scripture reference and text
//  - can hide words
//  - get the rendered text display


public class Scripture
{
    private string _fullVerse;
    private string _reference;
    private string _text;
    private string _randomWord;
    private string[] _textList;
    List <Word> _scriptureVerse = new List<Word>{};

    public Scripture(string reference, string text)
    // - create List
    // - split words
    // - create single Word objects
    // - put in List
    {
        _reference = reference;
        _text = text;
        Console.Clear();
        _textList = text.Split(" ");
        
    }

    private void HideWords()
    // - hide 3 words
    {
        
        // for (int i = 0; i < 3; i++)
        // {
        //     Randomizer(_textList);
        //     HideWord(_randomWord);
        //     _finalVerse = string.Join(" ", _textList);
        // }
    }

    private void GetRenderedText()
    // - find index of the word
    // - get the verse with the hidden word (?)
    { 
        
    }

    private void IsCompletelyHidden()
    // - the trigger if words will be hidden(?)
    {
        ConsoleKeyInfo keyPressed = Console.ReadKey();

        if (keyPressed.Key == ConsoleKey.Enter)
        {
            Console.Clear();
        }
    }

    // private string Randomizer(string[] list)
    // {
    //     do 
    //     {
    //         Random rnd = new Random();
    //         _randomWord = list[rnd.Next(_textList.Length)];
            
    //     } while(_randomWord.Contains("_"));
    //     _randomWordsList.Add(_randomWord);
        
    //     return _randomWord;
    // }

    // public void DisplayScripture(string reference, string text)
    // {
    //     Console.WriteLine(_fullVerse);
    //     Console.WriteLine();
    //     Console.WriteLine("Press ENTER to continue or type \"quit\" to finish:");
    //     KeyReader();
    // }

    // private void KeyReader()
    // {
    //     ConsoleKeyInfo keyPressed = Console.ReadKey();
    //     if (keyPressed.Key == ConsoleKey.Enter)
    //     {
    //         Console.Clear();
    //         Word word = new Word(_text);
    //         _text = word._finalVerse;
    //         _checker = true;
    //         _fullVerse = $"{_reference} - \"{_text}\""; 
    //         Console.WriteLine(_fullVerse);
    //     }
    //     else if (keyPressed.Key != ConsoleKey.Enter)
    //     {
    //         Console.WriteLine("Please type quit instead.");
    //     }
    // }

    // private bool ConfirmHide(List<string> newList)
    // {
    //     foreach (string item in newList)
    //         {
    //             if (item.Contains("hide"))
    //             {
    //                 return _checker = true; // Hide
    //             }
    //         }

    //         return _checker = false; // Don't hide
    // }

}