using System;

// Responsibilities:
// - keeps track of a single word (show or hidden).


public class Word
{
    private string _convertedWord;
    private List<string> _newList = new List<string>{};
    private string _randomWord;
    private int _wordIndex;
    public bool _displayReady;

    public Word(List<string> list)
    {

    }

    private string Randomizer()
    {
        return _randomWord;
    }

    private string HideWord(string word)
    {
        return _convertedWord;
    }

    private int GetIndex(string word)
    {
        return _wordIndex;
    }
    
    private List<string> NewWListConstructor(int index, string newWord)
    {
        return _newList;
    }

}