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
    private string hiddenWord;
    private string showWord;
    private string _scriptureVerse;
    private bool _isCompletelyHidden;
    private int counter = 0;
    private HashSet<string> _randomWordsList = new HashSet<string>();
    private string[] _textList;
    private string[] textList;
    List <string> _wordList = new List<string>();
    string hiddenText;
    

    public Scripture(string reference, string text)
    // - create List
    // - split words
    // - create single Word objects
    // - put in List
    {
        _reference = reference;
        _text = text;
        _scriptureVerse = $"{_reference} - \"{_text}\"";
        
        // _textList = text.Split(new string[] { ", ", ".", " " }, StringSplitOptions.RemoveEmptyEntries);
        _textList = _text.Split(" ");

        foreach (string line in _textList)
        {
            _wordList.Add(new string(line));
            
        }
        Console.Clear();
        Display();
    
    }

    public override string ToString()
    {
        return _text;
    }

    private void Display()
    {
        string keyPressed = "";
        Console.WriteLine(_scriptureVerse);
        do
        {
            Console.WriteLine("Press ENTER to continue or type \"quit\" to finish:");
            keyPressed = Console.ReadLine();
            
            _text = "";
            if (keyPressed == "quit")
            {
                break;
            }
            else
            {
                GetRenderedText();
                // if (_isCompletelyHidden == true)
                // {
                //     break;
                // }
                // if ()
            }
            
            
        } while (keyPressed != "quit");


    }


    private void HideWords()
    // - hide 3 words
    {
        
            Randomizer(_wordList);
            Word word = new Word(_randomWord);
            hiddenWord = word.GetRenderedWord();
            showWord = word.Show();
    }

    private string Randomizer(List<string> list)
    {
        do 
        {
            Random rnd = new Random();
            _randomWord = list[rnd.Next(list.Count)].ToString();

        // } while (_randomWordsList.Contains(_randomWord));
        } while (_randomWord.Contains("_"));
        _randomWordsList.Add(_randomWord);
        
        return _randomWord;
    }

    private void GetRenderedText()
    // - find index of the word
    // - get the verse with the hidden word (?)
    { 
        
        Console.Clear();
        _fullVerse = "";
        for (int i = 0; i < 3; i++)
        {
            HideWords();
            _wordIndex = _wordList.FindIndex(w => w ==_randomWord);
            _wordList[_wordIndex] = hiddenWord;
        }

        

        foreach (string line in _wordList)
        {
            _fullVerse += $"{line} ";
        }
        _text = _fullVerse;
        Console.WriteLine($"{_reference} - \"{_text}\".");
        Console.WriteLine(IsCompletelyHidden());

    }

    // private bool IsCompletelyHidden()
    // // - the trigger when all words are all hiddden
    // // - boolean
    // {
    //     // textList = _text.Split(" ");
    //     // foreach (string line in textList)
    //     // {
    //     //     if (line.Contains("_"))
    //     //     {
    //     //         counter++;
    //     //         Console.WriteLine(counter);
    //     //         Console.Write(line);
    //     //     }
    //     // }

    //     // if(counter == textList.Length){
    //     //     Console.WriteLine("test");
    //     //     _isCompletelyHidden = true;
    //     // }
    //     // else{
    //     //     _isCompletelyHidden = false;
    //     // }

    //     bool containsOnlyUnderscores = _wordList.All(s => s.All(c => c == '_'));
    //     _isCompletelyHidden = containsOnlyUnderscores;
    // return _isCompletelyHidden;
    // }

    private string IsCompletelyHidden()
    {
        // bool isAlphabet = _text.All(Char.IsAsciiLetter);
        
        if (isAlphabet == false)
        {
            // hiddenText = "All hidden";
            hiddenText = "NOTHING";
        }
        else
        {
            hiddenText = "hidden";
        }

        return hiddenText;
    }

}