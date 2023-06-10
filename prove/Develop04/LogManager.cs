using System;

public class LogManager
{
    public List<string> _logOptions = new List<string> {"Display", "Save", "Load"};
    private string[] _logSummary = new List<string>();
    public int _breathingCounter;
    public int _reflectingCounter;
    public int _listingCounter;
    private int _userChoice;
    private string _filename;


    public void DisplayLogOptions()
    {
        Console.Clear();
        Console.WriteLine("Summary Log Options:");

        for (int i = 0; i < _logOptions.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_logOptions[i]}");
        }

        Console.Write("\nWhat do you want to do? ");
        _userChoice = int.Parse(Console.ReadLine());
        Console.WriteLine();
        UserChoiceDeterminer();
    }

    private void UserChoiceDeterminer()
    {
        switch (_userChoice)
        {
            case 1:
                DisplaySummary();
                break;
            case 2:
                SaveFile();
                break;

            case 3:
                LoadFile();
                break;
        }
    }

    public void DisplaySummary()
    {
        Console.Clear();
        Console.WriteLine("\nHere is your Mindfulness Summary:\n");
        Console.WriteLine($"Breathing Activity: {_breathingCounter} times.");
        Console.WriteLine($"Reflecting Activity: {_reflectingCounter} times.");
        Console.WriteLine($"Listing Activity: {_listingCounter} times.\n");
    }

    public void SaveFile()
    {
        GetFileName();
        // Declares a list to store the values from the thrown list in this method.
        // Necessary for this method because each values are converted to be Excel-readable. 
        List<string> logSummary = new List<string>();
        // Assigns the headline value to a variable for an Excel heading.
        string headline = "Date,Time,Activity,Log";
        // Adds the headline to the created list as the first value.
        logSummary.Add(headline);

        // Iterates through the thrown list in the method.
        foreach (string entryString in _saveList)
        {
            // Declares an array to store the data which has been cleaned by the Split method.
            // Identifies what to split by using the pipe delimiter, then empty substrings are
            // removed from the entryValues array.
            string[] entryValues = entryString.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            // Stores the substrings to their specific categories by calling the ExcelWriter
            // method then removes the whitespaces from the substring.
            string date = ExcelWriter(entryValues[0].Trim());
            string time = ExcelWriter(entryValues[1].Trim());
            string prompt = ExcelWriter(entryValues[2].Trim());
            string response = ExcelWriter(entryValues[3].Trim());

            // Formats the segregated substrings into a single string and stores it in a
            // declared variable csvEntry.
            string csvEntry = $"{date},{time},{prompt},{response}";
            // Adds the formatted entries into the created list from above.
            csvEntries.Add(csvEntry);
        }

        // Instantiates the SteamWriter using the outputFile variable and uses the filename 
        // field as its file title.
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Writes each line from the list in the created file.
            foreach (string line in csvEntries)
            {
                outputFile.WriteLine(line);
            }
        }

        // A confirmation indicating the process has been completed.
        Console.WriteLine($"\nFile saved.\n");
    }

    public string[] LoadFile()
    {
        GetFileName();

        try
        {
            Console.WriteLine($"\nLoading file....");
            // Reads the file and uses the filename.
            _logSummary = System.IO.File.ReadAllLines(_filename);
            // A confirmation message that announces the loading of file is successful.
            Console.WriteLine($"\nFile loaded.\n");
        }
        catch (FileNotFoundException)
        {
            // Displays an error message if the file is not found within the containind folder.
            Console.WriteLine($"File not existing.\n");
        }
        // Returns the loaded strings into an array.
        return _logSummary;
    }

    private string GetFileName()
    {
        Console.WriteLine("What is the filename? ");
        Activity activity = new Activity();
        _filename = activity.GetUserInput();
        return _filename;
    }
}