using System;
using System.Text;
using System.Collections.Generic;

// Responsibilities:
// - keeps track of a single word to hide it.
public class Word
{
    // A field that stores the hidden equivalent of the passed word.
    private string _convertedWord;
    //  A field to store the passed word from the Scripture Class.
    private string _word;

    // Constructor Responsibilities:
    // - receives and stores the word for local use.
    public Word (string word)
    {
        _word = word;
    }

    // Overrides the ToString() method for checking/debugging.
    public override string ToString()
    {
        return _word;
    }

    // Hides and converts the word.
    private String Hide()
    {
        // Calls the StringBuilder class to enable manipulating each character of the word.
        StringBuilder builder = new StringBuilder();

        // Checks each character of the word if it is a letter or not.
        foreach (char c in _word)
        {
            if (Char.IsLetter(c))
            {
                // When the word's characters are still letters, it appends underscores 
                // according to the word length.
                builder.Append('_');
            }
            else
            {
                // If it contains other characters, it appends the character at the end of the
                // word.
                builder.Append(c);
            }
        }
        // Converts the builder to string and stores it as a converted word.
       _convertedWord = builder.ToString();
        return _convertedWord;
    }

    // - provides access the converted word  
    public String GetRenderedWord()
    {
        Hide();
        return _convertedWord;
    }
}