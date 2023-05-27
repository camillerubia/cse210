using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


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
    private HashSet<string> _randomWordsList = new HashSet<string>();
    private string[] _textList;
    List <string> _wordList = new List<string>();
    private int counter;

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
            _wordList.Add(line);
            
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
        Console.WriteLine($"{_scriptureVerse}\n");
        do
        {
            Console.WriteLine("Press ENTER to continue or type \"quit\" to finish:");
            keyPressed = Console.ReadLine();
            
            if (keyPressed == "quit")
            {
                break;
            }
            _text = "";
            GetRenderedText();

            if (IsCompletelyHidden())
            {
                break;
            }      
        } while (true);
    }

    private void HideWords()
    // - hide single words
    {
        counter++;
        Randomizer(_wordList);
        Word word = new Word(_randomWord);
        hiddenWord = word.GetRenderedWord();
        showWord = word.Show();
    }

    private string Randomizer(List<string> list)
    // - randomize words
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

        if (counter < (_wordList.Count - 2))
        {
            for (int i = 0; i < 3; i++)
            {
                HideWords();
                _wordIndex = _wordList.FindIndex(w => w ==_randomWord);
                _wordList[_wordIndex] = hiddenWord;
            }
        }
        else if ((counter < (_wordList.Count - 1)))
        {
            for (int i = 0; i < 2; i++)
            {
                HideWords();
                _wordIndex = _wordList.FindIndex(w => w ==_randomWord);
                _wordList[_wordIndex] = hiddenWord;
            }
        }
        else
        {
            HideWords();
            _wordIndex = _wordList.FindIndex(w => w ==_randomWord);
            _wordList[_wordIndex] = hiddenWord;
        }

        int ctr = 0;

        foreach (string line in _wordList)
        {
            if(ctr == 0)
            {
                _fullVerse += $"{line}";
                ctr++;
            }
            else
            {
                _fullVerse += $" {line}";
            }
            
        }
        _text = _fullVerse;
        Console.WriteLine($"{_reference} - \"{_text}\"\n");    
    }
    private bool IsCompletelyHidden()
    // Make sure all the words are hidden.
    {
        bool containsOnlyUnderscores = _wordList.All(word => word.All(c => !Char.IsLetter(c)));
        return containsOnlyUnderscores;
    }
}