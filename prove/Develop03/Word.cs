using System;
using System.Text;
using System.Collections.Generic;

// Responsibilities:
// - keeps track of a single word (show or hidden).
public class Word
{
    private string _convertedWord;
    public bool _displayReady;
    public string _word;

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

        if (_word.Contains(","))
        {
            _word = _word.Replace(",", "");
                
            for (int i = 0; i <_word.Length; i++)
            {
                builder.Append('_');
            }
            builder.Append(',');
            
        }
        else if (_word.Contains("."))
        {
            _word = _word.Replace(".", "");
                
            for (int i = 0; i <_word.Length; i++)
            {
                builder.Append('_');
            }
            builder.Append('.');
            
        }
        else
        {
            for (int i = 0; i <_word.Length; i++)
            {
                builder.Append('_');
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