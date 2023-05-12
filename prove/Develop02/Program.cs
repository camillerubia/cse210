using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Journal Program");
    }  
}

public class JournalProgram
{
    public string _journalProgram;
    public Journal _journal = new Journal();
    public FileManager _fileManager = new FileManager();
    public Entry _entry = new Entry();
    public PromptGenerator _prompt = new PromptGenerator();
}