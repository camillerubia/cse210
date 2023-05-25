using System;
using System.Text;

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
    private string _finalVerse;
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
            _finalVerse = string.Join(" ", _textList);
        }
        Console.WriteLine(_finalVerse);
    }

    private string Randomizer(string[] list)
    {
        do
        {
            Random rnd = new Random();
            _randomWord = list[rnd.Next(_textList.Length)];
        } while (_randomWordsList.Contains(_randomWord));
        
        _randomWordsList.Add(_randomWord);
        return _randomWord;
    }

    private string HideWord(string randomWord)
    {
        _wordIndex = Array.IndexOf(_textList, randomWord);

        StringBuilder builder = new StringBuilder();

        for (int i = 0; i <randomWord.Length; i++)
        {
            builder.Append('_');
        }

       _textList[_wordIndex] = builder.ToString();
       _convertedWord = _textList[_wordIndex];
        return _convertedWord;
    }
}