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
    // A field to store the reference from the constructor's parameter.
    private string _reference;
    // A field to store the text from the constructor's parameter for class usage.
    private string _text;
    // A field to store the randomWord chosen from the Randomizer() method.
    private string _randomWord;
    // A field to store the index of the random word.
    private int _wordIndex;
    // A field to store the converted word from the Word class.
    private string _hiddenWord;
    // A field to store the reference with the text.
    private string _scriptureVerse;
    // A HashSet which makes sure that the random word doesn't duplicate and stores all
    // of the chosen random words.
    private HashSet<string> _randomWordsList = new HashSet<string>();
    // A List to store all the words from the text and is updated when words are hidden.
    List <string> _wordList = new List<string>();
    // A field that ensures the correct loop each time user presses ENTER.
    private int _counter;

    // Constructor Responsibilities:
    // - receives parameters and stores them for local use.
    // - calls the respective methods to start process.
    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
       
        Console.Clear();
        // Segregates the data and stores it in the list.
        _wordList = _text.Split(" ").ToList();

        // Calls the Display method for user to see.
        Display();   
    }

    // Overrides the ToString() method for checking/debugging.
    public override string ToString()
    {
        return _text;
    }

    // Displays the scripture verse, and calls the respective methods within the
    // class to process data.
    private void Display()
    {
        // A local field with no value to store user input.
        string keyPressed = "";
        // Assigns value to _scripture verse for display.
        _scriptureVerse = $"{_reference} - \"{_text}\"";
        Console.WriteLine($"{_scriptureVerse}\n");

        // Starts a do-while loop for user interaction.
        do
        {
            Console.WriteLine("Press ENTER to continue or type \"quit\" to finish:");
            keyPressed = Console.ReadLine();
            
            // When user types quit, the program ends.
            if (keyPressed == "quit")
            {
                break;
            }
            // Resets the field into blank for storing new data later.
            _text = "";
            // Calls the GetRenderedText() method to fetch the text with/out the hidden words.
            GetRenderedText();

            // Checks and calls if the IsCompletelyHidden() is true to exit the program when
            // all words are all hidden.
            if (IsCompletelyHidden())
            {
                break;
            }
        // Repeats the loop until other conditions are met.   
        } while (true);
    }

    // Calls the Randomizer() and instantiates the Word Class 
    // Passes the random word to the class and fetches the hidden word from one of its
    // class methods.
    private void HideWords()
    {
        // A field that ensures the call count of HideWords() method 
        _counter++;
        // Calls the local method to pass on the list created from the constructor.
        Randomizer(_wordList);
        // Instantiates the Word class and passes on the random word.
        Word word = new Word(_randomWord);
        // Gets the converted word from the Word Class GetRenderedWord() method.
        _hiddenWord = word.GetRenderedWord();
    }

    // Randomizes the list and returns a word from the list.
    private string Randomizer(List<string> list)
    {
        // Instantiates Random and stores it into rnd
        Random rnd = new Random();

        // Initializes a do-while loop to ensure that no random words will duplicate.
        do 
        {
            // Stores the chosen random word in a field.
            _randomWord = list[rnd.Next(list.Count)].ToString();

        // Checks if the random word is already hidden, will repeat the loop if its hidden.
        } while (_randomWord.Contains("_"));

        // Adds the random words in the HashSet.
        _randomWordsList.Add(_randomWord);
        return _randomWord;
    }

    // Converts the whole text with the hidden and shown words and stitches them together.
    private void GetRenderedText()
    { 
        Console.Clear();
        // Resets the fields to ensure clean state for new data to store later.
        _scriptureVerse = "";

        // Checks if the word count in the list can hide 3 words at a time.
        if (_counter < (_wordList.Count - 2))
        {
            // Calls the HideWords() for 3 times and finds its index to replace in the list.
            for (int i = 0; i < 3; i++)
            {
                HideWords();
                _wordIndex = _wordList.FindIndex(w => w ==_randomWord);
                _wordList[_wordIndex] = _hiddenWord;
            }
        } 
        // Checks if the word count in the list can hide 2 words at a time.
        else if ((_counter < (_wordList.Count - 1)))
        {
            // Calls the HideWords() for 2 times and finds its index to replace in the list.
            for (int i = 0; i < 2; i++)
            {
                HideWords();
                _wordIndex = _wordList.FindIndex(w => w ==_randomWord);
                _wordList[_wordIndex] = _hiddenWord;
            }
        }
        // When there's only 1 remaining word left unhidden, the process repeats for 1 time.
        else
        {
            HideWords();
            _wordIndex = _wordList.FindIndex(w => w ==_randomWord);
            _wordList[_wordIndex] = _hiddenWord;
        }

        // Iterates through the wordList and stores each line in the text field.
        foreach (string line in _wordList)
        {
            _text += $"{line} ";
        }

        // Trims the end of the last line.
        _text = _text.TrimEnd();
        // Updates the data of the scriptureVerse.
        _scriptureVerse = $"{_reference} - \"{_text}\"";
        // Displays the new scriptureVerse with the hidden words.
        Console.WriteLine($"{_scriptureVerse}\n");
    }

    // Make sure all the words are hidden.
    private bool IsCompletelyHidden()
    {
        // A boolean that checks all of the characters in the wordList if all of it are `_`.
        bool isHidden = _wordList.All(word => word.All(c => !Char.IsLetter(c)));
        return isHidden;
    }
}