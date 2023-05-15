using System;

// Responsibilities:
//  - acquires user response from the prompt
//  - generates the current date
//  - merges the response with the date and prompt
//  - creates entry list

public class Entry 
{
    // Declares the Datetime and stores it into a static field.
    static DateTime dateNow = DateTime.Now;
    // Stores the current date into a local variable.
    string _currentDate = dateNow.ToShortDateString();
    // Declares a static field with the current time and converted it to uppercase.
    static string _currentTime = dateNow.ToString("h:mm tt").ToUpper();
    // A field that stores user's response.
    public string _response;
    // A field to store the formatted single line journal entry.
    public string _entry;
    // A field that stores the random prompt from the PromptGenerator Class.
    public string entryPrompt;
    // A blank field which value will be assigned by the Journal Class program.
    public string _singleEntry;
    // A field that assigns an empty list for all the entries collected which the Journal Class
    // adds its values to it.
    public List<string> _entryList = new List<string>();
    // Instantiates the PromptGenerator class and stores its attributes in a field.
    public PromptGenerator prompt = new PromptGenerator();
    // A field that assigns an empty list for all the entries collected which the Journal Class
    // adds its values to it for storing in a CSV file.
    public List<string> _csvList = new List<string>();
    // A declared field for storing the values without a format. Will be used for storing values
    // in a CSV file.
    public string _csvEntry;

    // A method that displays a random prompt and asks the user for a response input.
    public void InputEntry()
    {
        Console.WriteLine("Prompt:");
        // Calls the RandomPrompt method from the PromptGenerator Class which then returns a 
        // single prompt then stores it into entryPrompt.
        entryPrompt = prompt.RandomPrompt();
        Console.WriteLine(entryPrompt);
        Console.Write("> ");
        // Asks the user for an input response.
        _response = Console.ReadLine();
        Console.WriteLine();
    }
    
    // A method that compiles all the values in a single line and returns it.
    public string JournalEntry()
    {
        // Formats the entry with the labels for quick display (display without saving/loading).
        _entry = $"Date: {_currentDate} Time: {_currentTime}\nPrompt: {entryPrompt}\n- {_response}";
        // Returns the strings with labes.
        return _entry;
    }

    // A method that stores simplified compiled values (without labels) for CSV file.
    public string SeparateEntries()
    {
        // Simplifies the format without labels.
        _csvEntry = $"{_currentDate}| {_currentTime}| {entryPrompt}| {_response}";
        // Returns the string without labels.
        return _csvEntry;
    }
}