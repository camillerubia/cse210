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

        if (_word.Contains(",") || _word.Contains("."))
        {
            if (_word.Contains(","))
            {
                _word = _word.Replace(",", "");
            }
            else
            {
                _word = _word.Replace(".", "");
            }
            
            for (int i = 0; i <_word.Length; i++)
            {
                builder.Append('_');
            }
            
            if (_word.Contains(","))
            {
                builder.Append(',');
            }
            else 
            {
                builder.Append('.');
            }
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

    private void IsHidden()
    // - check if the word is hidden?
    {

    }

    public String GetRenderedWord()
    // - access the converted word
    {
        Hide();
        return _convertedWord;
    }

    

    // private string HideWord(string randomWord)
    // {
    //     _wordIndex = Array.IndexOf(_textList, randomWord);

    //     StringBuilder builder = new StringBuilder();

    //     for (int i = 0; i <randomWord.Length; i++)
    //     {
    //         builder.Append('_');
    //     }

    //    _textList[_wordIndex] = builder.ToString();
    //    _convertedWord = _textList[_wordIndex];
    //     return _convertedWord;
    // }
}