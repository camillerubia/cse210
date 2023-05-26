using System;
using System.Text;
using System.Collections.Generic;

// Responsibilities:
// - keeps track of a single word (show or hidden).


public class Word
{
    private string _convertedWord;
    private HashSet<string> _randomWordsList = new HashSet<string>();
    private string _randomWord;
    private int _wordIndex;
    public bool _displayReady;
    private string[] _textList;
    public string _finalVerse;
    public string items;
    public Word(string text)
    {
        _textList = text.Split(" ");
        for (int i = 0; i < 3; i++)
        {
            Randomizer(_textList);
            HideWord(_randomWord);
            _finalVerse = string.Join(" ", _textList);
        }
    }

    private void Hide()
    {

    }

    private void Show()
    {

    }

    private void IsHidden()
    {

    }

    private void GetRenderedText()
    {
        
    }

    // private string Randomizer(string[] list)
    // {
    //     do 
    //     {
    //         Random rnd = new Random();
    //         _randomWord = list[rnd.Next(_textList.Length)];
            
    //     } while(_randomWord.Contains("_"));
    //     _randomWordsList.Add(_randomWord);
        
    //     return _randomWord;
    // }

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