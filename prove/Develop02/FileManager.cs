using System;

// Responsibilities:
//  - acquire filename
//  - save the journal to a file
//  - locate the filename
//  - replace the current entries
//  - display the file journal entries

public class FileManager
{    
    public string[] _loadJournal;
    public string filename;

    public string GetFileName()
    {
        Console.Write($"\nWhat is the filename? ");
        filename = Console.ReadLine();
        return filename;
    }

    public void SaveFile(string filename, List<string> _saveList)
    {
        Console.WriteLine($"\nSaving file....");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string line in _saveList)
            {
                outputFile.WriteLine(line);
            }
        }
        Console.WriteLine($"\nFile saved.\n");
    }
    
    public string[] LoadFile(string filename)
    {
        Console.WriteLine($"\nLoading file....");
        _loadJournal = System.IO.File.ReadAllLines(filename);
        Console.WriteLine($"\nFile loaded.\n");
        return _loadJournal;
    }
}