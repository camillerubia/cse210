using System;

// Responsibilities:
//  - acquires user response from the prompt
//  - generates the current date
//  - merges the response with the date and prompt
//  - creates entry list

public class Entry 
{
    static DateTime dateNow = DateTime.Now;
    string _currentDate = dateNow.ToShortDateString();
    static string _currentTime = DateTime.Now.ToString("h:mm tt").ToUpper();
    public string _response;
    public string _entry;
    public string entryPrompt;
    public string _singleEntry;
    public List<string> _entryList = new List<string>();    
    public PromptGenerator prompt = new PromptGenerator();
    public List<string> _csvList = new List<string>();
    public string _csvEntry;

    public void InputEntry()
    {
        Console.WriteLine("Prompt:");
        entryPrompt = prompt.RandomPrompt();
        Console.WriteLine(entryPrompt);
        Console.Write("> ");
        _response = Console.ReadLine();
        Console.WriteLine();
    }
    
    public string JournalEntry()
    {
        _entry = $"Date: {_currentDate} Time: {_currentTime}\nPrompt: {entryPrompt}\n- {_response}";
        return _entry;
    }

    public string SeparateEntries()
    {
        _csvEntry = $"{_currentDate}| {_currentTime}| {entryPrompt}| {_response}";
        return _csvEntry;
    }
}