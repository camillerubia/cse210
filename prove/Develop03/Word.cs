using System;
using System.Text;
using System.Collections.Generic;

// Responsibilities:
// - keeps track of a single word (show or hidden).
public class Word
{
    private string _convertedWord;
    private string _word;

    public Word(string word)
    {
        _word = word;
    }

    public override string ToString()
    {
        return _word;
    }
    
    private String Hide()
    // - hide the word and convert it
    {
        StringBuilder builder = new StringBuilder();

        foreach (char c in _word)
        {
            if (Char.IsLetter(c))
            {
                builder.Append('_');
            }
            else
            {
                builder.Append(c);
            }
        }
       _convertedWord = builder.ToString();
        return _convertedWord;
    }

    public String Show()
    // - show the word
    {
        return _word;
    }
    public String GetRenderedWord()
    // - access the converted word
    {
        Hide();
        return _convertedWord;
    }
}