using System;
using System.Text;
using System.Collections.Generic;

// Responsibilities:
// - keeps track of a single word (show or hidden).


public class Word
{
    private string _convertedWord;
    public bool _displayReady;
    private String _word;

    public Word(String word)
    {
        _word = word;
    }

    private string Hide()
    // - hide the word and convert it
    {
        StringBuilder builder = new StringBuilder();

        for (int i = 0; i <_word.Length; i++)
        {
            builder.Append('_');
        }

       _convertedWord = builder.ToString();
        return _convertedWord;
    }

    public override string ToString()
    {
        return _word;
    }

    public string Show()
    // - show the word
    {
        return _word;
    }

    private void IsHidden()
    // - check if the word is hidden
    {

    }

    public string GetRenderedWord()
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