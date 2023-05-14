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
    public string[] _loadJournal;

    public Entry entry = new Entry();
    public void SaveFile()
    {
        Console.Write("What is the filename? ");
        _saveFilename = Console.ReadLine();
        using (StreamWriter saveFile = new StreamWriter(_saveFilename))
        {
            foreach (string line in entry._entryList)
            {
                saveFile.WriteLine(line);
            }
        }
    }

    public string[] GetFileName()
    {
        Console.Write("What is the filename? ");
        _loadFilename = Console.ReadLine();
       _loadJournal = System.IO.File.ReadAllLines(_loadFilename);
        return _loadJournal;
    }
    
}