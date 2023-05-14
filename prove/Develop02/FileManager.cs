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
        Console.WriteLine();
        Console.Write("What is the filename? ");
        filename = Console.ReadLine();
        return filename;
    }

    public void SaveFile(string filename, List<string> _saveList)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string line in _saveList)
            {
                outputFile.WriteLine(line);
            }
        }
    }
    
    public string[] LoadFile(string filename)
    {
       _loadJournal = System.IO.File.ReadAllLines(filename);
        return _loadJournal;
    }
}