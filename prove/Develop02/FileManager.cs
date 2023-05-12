using System;

// Responsibilities:
//  - acquire filename
//  - save the journal to a file
//  - locate the filename
//  - replace the current entries
//  - display the file journal entries

public class FileManager
{
    public static string _saveFilename;
    
    public static string _loadFilename;
    public void SaveFile()
    {

    }

    public void GetFileName()
    {
        Console.Write("What is the filename? ");
        _loadFilename = Console.ReadLine();
    }
    public string[] _loadJournal = System.IO.File.ReadAllLines(_loadFilename);
}