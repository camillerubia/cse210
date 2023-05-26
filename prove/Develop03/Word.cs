using System;
using System.Text;
using System.Collections.Generic;

// Responsibilities:
// - keeps track of a single word (show or hidden).


public class Word
{
    private string _convertedWord;
    private HashSet<string> _randomWordsList = new HashSet<string>();

    private int _wordIndex;
    public bool _displayReady;
    
    public string _finalVerse;
    public string items;
    public Word(string word)
    {
        
    }

    // private string Hide()
    // // - hide the word and convert it (?)
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

    private void Show()
    // - show the word
    {

    }

    private void IsHidden()
    // - check if the word is hidden
    {

    }

    public void GetRenderedWord()
    // - access the converted word
    {
        
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