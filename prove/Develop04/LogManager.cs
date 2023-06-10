using System;
using System.Collections.Generic;
using System.IO;

// LogManager Class:
// - The single class that doesn't inherit from the Activity Class
// - A constructor is not needed for this class.

// Responsibilities:
// - Counts the number of times the user has performed an activity.
// - Saves and/or loads the Activity Log into/from a file.

public class LogManager
{
    // A pre-set list for the log options to display inside a method.
    public List<string> _logOptions = new List<string> {"Display", "Save", "Load"};
    // A list to store the lines of strings from a file.
    private List<string> _fileLogSummary = new List<string>();
    // A list to store all the logs either for saving to a file later or for displaying.
    private List<string> _logSummary = new List<string>();
    // Activity counters (breathing, reflecting, and listing)
    public int _breathingCounter;
    public int _reflectingCounter;
    public int _listingCounter;
    // A field to store the user input.
    private int _userChoice;
    // A field to store the filename.
    private string _filename;
    // Stores the current date into a local variable.
    string _currentDate = DateTime.Now.ToShortDateString();
    // Declares a static field with the current time and converted it to uppercase.
    static string _currentTime = DateTime.Now.ToString("h:mm tt").ToUpper();

    // A method to display the log functionalities/options. 
    public void DisplayLogOptions()
    {
        // Loops through the list until the user chooses a correct option
        while (true)
        {
            // Menu heading for the Log Options.
            Console.WriteLine("Summary Log Options:");

            // Iterates through the list and displays the options in a numbered format.
            for (int i = 0; i < _logOptions.Count; i++)
            {
                Console.WriteLine($"{i+1}. {_logOptions[i]}");
            }

            try
            {
                // Asks the user for their choice.
                Console.Write("\nWhat do you want to do? ");
                _userChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                // Calls the method to perform its functionalities according to the user choice.
                UserChoiceDeterminer();
                // Breaks from the while loop so that the Log Options Menu will not display again.
                break;
            }

            // An error catcher if the user types a letter and not a number.
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Invalid choice.\n");
            }
        }
    }

    // A method that determines which helper methods to call and what lists to pass on.
    private void UserChoiceDeterminer()
    {
        switch (_userChoice)
        {
            case 1:
                // Calls the method and stores it in the List to pass on as a parameter.
                _logSummary = LogEntry();
                // Calls on the method and passes on the list for display.
                DisplaySummary(_logSummary);
                break;

            case 2:
                // Calls the method to save the passed list to a file.
                SaveFile(_logSummary);
                break;

            case 3:
                // Calls the method to load from a file and stores it in a list.
                _fileLogSummary = LoadFile();
                // Calls the method again to display the list from a file.
                DisplaySummary(_fileLogSummary);
                break;
        }
    }

    // A method that displays the log summary from a list as a parameter.
    public void DisplaySummary(List<string> logSummary)
    {
        Console.Clear();
        
        // Summary heading
        Console.WriteLine("Mindfulness Summary:\n");

        // Iterates through each line in the list and displays them.
        foreach (string line in logSummary)
        {
            Console.WriteLine(line);
        }
    }

    // A method that receives a list as a parameter and saves it in a file.
    public void SaveFile(List<string> logSummary)
    {
        // Calls the method to get the filename.
        _filename = GetFileName();

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

    // A method that loads from a file
    public List<string> LoadFile()
    {
        // Calls the method to get the filename.
        _filename = GetFileName();

        try
        {
            Console.WriteLine($"\nLoading file....");
            // Reads the file and converts it into a List then stores it.
            _fileLogSummary = System.IO.File.ReadAllLines(_filename).ToList();

            // A confirmation message that announces the loading of file is successful.
            Console.WriteLine($"\nFile loaded.\n");
        }

        catch (FileNotFoundException)
        {
            // Displays an error message if the file is not found within the containind folder.
            Console.WriteLine($"File not existing.\n");
        }
        // Returns the loaded strings into a List.
        return _fileLogSummary;
    }

    // A method that acquires the filename from the user.
    private string GetFileName()
    {
        Console.WriteLine("What is the filename? ");
        _filename = Console.ReadLine();
        return _filename;
    }

    // A method that stores the count in each activity and adds them all in a List.
    private List<string> LogEntry()
    {
        // Stores the date in a specified format.
        string date = $"{_currentDate}, {_currentTime}";
        // Stores each Activities in a log in a specific format.
        string breathingLog = $"{_breathingCounter}x Breathing Activity";
        string reflectingLog= $"{_reflectingCounter}x Reflecting Activity";
        string listingLog = $"{_listingCounter}x Listing Activity";
        // Sets the string to be added later when the user haven't performed any activities yet.
        string line = "You have not done any activities yet.";

        // Adds the date into the Log Summary as the first line.
        _logSummary.Add(date);

        // Checks if the user has performed any of the activities.
        if (_breathingCounter != 0 || _reflectingCounter != 0 || _listingCounter != 0)
        {
            // Removes the line if the user has performed any of the three activites: Breathing,
            // Reflecting or Listing according to their counters.
            _logSummary.Remove(line);

            // Conditions that will add the specific activity and their count into the List.
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
        // If the user hasn't performed any activities yet, the line will be added to the empty List for display later.
        else
        {
            _logSummary.Add(line);
        }

        // Returns the List to pass as a parameter for display.
        return _logSummary;
    }
}