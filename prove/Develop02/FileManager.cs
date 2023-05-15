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
            return checker = true;
        }
        else {
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
        string headline = "Date,Time,Prompt,Response";
        csvEntries.Add(headline);

        foreach (string entryString in _saveList)
        {
            string[] entryValues = entryString.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            string date = ExcelWriter(entryValues[0].Trim());
            string time = ExcelWriter(entryValues[1].Trim());
            string prompt = ExcelWriter(entryValues[2].Trim());
            string response = ExcelWriter(entryValues[3].Trim());

            string csvEntry = $"{date},{time},{prompt},{response}";
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

    public string ExcelWriter(string line)
    {
        if (line.Contains(","))
        {
            line = $"\"{line}\"";
        }
        return line;
    }

    public string[] LoadFile(string filename)
    {
        Console.WriteLine($"Checking file....\n");
        try
        {
            Console.WriteLine($"\nLoading file....");
            _loadJournal = System.IO.File.ReadAllLines(filename);
            Console.WriteLine($"\nFile loaded.\n");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File not existing.\n");
        }
        return _loadJournal;
    }
}