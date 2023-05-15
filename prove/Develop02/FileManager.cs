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

    public bool checker;

    public string GetFileName()
    {
        Console.Write($"\nWhat is the filename? ");
        filename = Console.ReadLine();
        return filename;
    }

    public bool FileChecker(string filename)
    {
        if (filename.Contains("csv"))
        {
            Console.WriteLine("Saved as CSV");
            return checker = true;
        }
        else {
            Console.WriteLine("Not saved as CSV");
            return checker = false;
        }
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
    
    public void SaveCsvFile(string filename, List<string> _saveList)
    {
        Console.WriteLine($"\nSaving csv file....");

        List<string> csvEntries = new List<string>();

        foreach (string entryString in _saveList)
        {
            string[] entryValues = entryString.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            string date = entryValues[0].Trim();
            string prompt = entryValues[1].Trim();
            string response = entryValues[2].Trim();

            string csvEntry = $"{date},{prompt},{response}";
            csvEntries.Add(csvEntry);
        
        }

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string line in csvEntries)
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