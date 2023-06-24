using System;
using System.Collections.Generic;

public class GoalManager:Goal
{
    private string _filename;
    private List<string> _loadGoalList = new List<string>();

    public GoalManager()
    {
        
    }

    protected override void RecordEvent()
    {
    }

    protected override bool IsComplete()
    {
        return _checker;
    }

    private void GetFileName()
    {
        Console.Clear();
        Console.Write("What is the filename? ");
        _filename = Console.ReadLine();
    }

    public void SaveFile()
    {
        GetFileName();
         // A display message before storing the entries into a file.
        Console.WriteLine($"\nSaving file....");
        
        // Instantiates the SteamWriter using the outputFile variable and uses the filename 
        // field as its file title.
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            // Writes each line from the list in the created file.
            foreach (string line in _loadGoalList)
            {
                outputFile.WriteLine(line);
            }
        }
        // A confirmation indicating the process has been completed.
        Console.WriteLine($"\nFile saved.\n");
    }

    public List<string> LoadFile()
    {
        GetFileName();
        // Calls the method to get the filename.
        // _filename = GetFileName();

        try
        {
            Console.WriteLine($"\nLoading file....");
        //     // Reads the file and converts it into a List then stores it.
        //     _fileLogSummary = System.IO.File.ReadAllLines(_filename).ToList();

            // A confirmation message that announces the loading of file is successful.
            Console.WriteLine($"\nFile loaded.\n");
        }

        catch (FileNotFoundException)
        {
            // Displays an error message if the file is not found within the containind folder.
            Console.WriteLine($"File not existing.\n");
        }
        // // Returns the loaded strings into a List.
        return _loadGoalList;
    }
}