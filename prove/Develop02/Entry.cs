using System;

// Responsibilities:
//  - acquires user response from the prompt
//  - generates the current date
//  - merges the response with the date and prompt
//  - creates entry list

public class Entry 
{
    static DateTime timeNow = DateTime.Now;
    string _currentDate = timeNow.ToShortDateString();

    int integer = Math.Abs(9);

    public string _response;
    
    public string _entry;
    public List<string> _entryList = new List<string>();    

    public PromptGenerator _prompt = new PromptGenerator();

    public void InputEntry()
    {
        
    }

    public void JournalEntry()
    {

    }
}