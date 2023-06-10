using System;
using System.Collections.Generic;
using System.IO;

public class LogManager
{
    public List<string> _logOptions = new List<string> {"Display", "Save", "Load"};
    private List<string> _fileLogSummary = new List<string>();
    private List<string> _logSummary = new List<string>();
    public int _breathingCounter;
    public int _reflectingCounter;
    public int _listingCounter;
    private int _userChoice;
    private string _filename;

    // Declares the Datetime and stores it into a static field.
    static DateTime dateNow = DateTime.Now;
    // Stores the current date into a local variable.
    string _currentDate = dateNow.ToShortDateString();
    // Declares a static field with the current time and converted it to uppercase.
    static string _currentTime = dateNow.ToString("h:mm tt").ToUpper();

    public void DisplayLogOptions()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Summary Log Options:");

            for (int i = 0; i < _logOptions.Count; i++)
            {
                Console.WriteLine($"{i+1}. {_logOptions[i]}");
            }

            try
            {
                Console.Write("\nWhat do you want to do? ");
                _userChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                UserChoiceDeterminer();
                break;
            }
        
            catch (FormatException)
            {
                Console.WriteLine("Invalid choice.\n");
                continue;
            }
        }
    }

    private void UserChoiceDeterminer()
    {
        switch (_userChoice)
        {
            case 1:
                DisplaySummary(_logSummary);
                break;
            case 2:
                SaveFile(_logSummary);
                break;

            case 3:
                LoadFile();
                DisplaySummary(_fileLogSummary);
                break;
        }
    }

    public void DisplaySummary(List<string> logSummary)
    {
        Console.Clear();
        logSummary = LogEntry();
        Console.WriteLine("\nHere is your Mindfulness Summary:\n");
        Console.WriteLine();

        foreach (string line in logSummary)
        {
            Console.WriteLine(line);
        }

    }

    public void SaveFile(List<string> logSummary)
    {
        GetFileName();

        // Instantiates the SteamWriter using the outputFile variable and uses the filename 
        // field as its file title.
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            // Writes each line from the list in the created file.
            foreach (string line in logSummary)
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

        try
        {
            Console.WriteLine($"\nLoading file....");
            // Reads the file and uses the filename.
            string[] lines = System.IO.File.ReadAllLines(_filename);
            _fileLogSummary = lines.ToList();

            // A confirmation message that announces the loading of file is successful.
            Console.WriteLine($"\nFile loaded.\n");
        }

        catch (FileNotFoundException)
        {
            // Displays an error message if the file is not found within the containind folder.
            Console.WriteLine($"File not existing.\n");
        }
        // Returns the loaded strings into an array.
        return _fileLogSummary;
    }

    private string GetFileName()
    {
        Console.WriteLine("What is the filename? ");
        _filename = Console.ReadLine();
        return _filename;
    }

    private List<string> LogEntry()
    {
        string date = $"{_currentDate}, {_currentTime}";
        string breathingLog = $"{_breathingCounter}x Breathing Activity";
        string reflectingLog= $"{_reflectingCounter}x Reflecting Activity";
        string listingLog = $"{_listingCounter}x Listing Activity";
        string line = "You have not done any activities yet.";

        _logSummary.Clear();
        _logSummary.Add(date);

        if (_breathingCounter != 0 || _reflectingCounter != 0 || _listingCounter != 0)
        {
            // Removes the line if the user has performed any of the three activites: Breathing,
            // Reflecting or Listing according to their counters.
            _logSummary.Remove(line);

            if (_breathingCounter != 0)
            {
                _logSummary.Add(breathingLog);
            }

            if (_reflectingCounter != 0)
            {
                _logSummary.Add(reflectingLog);
            }

            if (_listingCounter != 0)
            {
                _logSummary.Add(listingLog);
            }
        }

        else
        {
            _logSummary.Add(line);
        }

        return _logSummary;
    }
}