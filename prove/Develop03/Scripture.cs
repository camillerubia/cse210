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
    private int _wordIndex;
    private HashSet<string> _randomWordsList = new HashSet<string>();
    private string[] _textList;
    List <Word> _scriptureVerse = new List<Word>();

    public Scripture(string reference, string text)
    // - create List
    // - split words
    // - create single Word objects
    // - put in List
    {
        _reference = reference;
        _text = text;
        // Console.Clear();
        _textList = text.Split(" ");

        foreach (string line in _textList)
        {
            _scriptureVerse.Add(new Word(line));
        }
        HideWords();
        Display();
    }



    private void HideWords()
    // - hide 3 words
    {
        for (int i = 0; i < 3; i++)
        {
            Randomizer(_scriptureVerse);
        }

    }

    private string Randomizer(List<Word> list)
    {
        do 
        {
            Random rnd = new Random();
            _randomWord = list[rnd.Next(list.Count)].ToString();
            
        } while(_randomWord.Contains("_"));
        _randomWordsList.Add(_randomWord);
        
        return _randomWord;
    }

    private void Display()
    {
        foreach (string line in _randomWordsList)
        {
            Console.WriteLine(line);
        }
    }

    public override string ToString()
    {
        return base.ToString();
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