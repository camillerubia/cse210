using System;
using System.Text;

// Responsibilities:
// - keeps track of a single word (show or hidden).


public class Word
{
    private string _convertedWord;
    private List<string> _newList = new List<string>{};
    private string _randomWord;
    private int _wordIndex;
    public bool _displayReady;
    private string[] _textList;
    private string _finalVerse;
    private int index;

    public Word(string text)
    {
        _textList = text.Split(" ");
        for (int i = 0; i < 3; i++)
        {
            Randomizer(_textList);
            Console.WriteLine($"Random Word: {_randomWord}");
            HideWord(_randomWord);
            Console.WriteLine($"Converted Word: {_convertedWord}");
            Console.WriteLine($"Index: {_wordIndex}");
        }
        Console.WriteLine($"New verse: {NewList(_wordIndex, _convertedWord)}");
    }

    private string Randomizer(string[] list)
    {
        Random rnd = new Random();
        _randomWord = list[rnd.Next(_textList.Length)];
        return _randomWord;
    }

    private string HideWord(string randomWord)
    {
        int GetIndex()
        {
            if (_textList.Contains(randomWord))
            {
            _wordIndex = Array.IndexOf(_textList, randomWord);
            }
            return _wordIndex;
        }

        GetIndex();

        StringBuilder builder = new StringBuilder();

        for (int i = 0; i <randomWord.Length; i++)
        {
            builder.Append('_');
        }

        _convertedWord = builder.ToString();
        return _convertedWord;
    }

    private string NewList(int index, string newWord)
    {
        _textList[index] = newWord;
        _finalVerse = string.Join(" ", _textList);
        return _finalVerse;
    }
}