using System;

// Responsibilities:
//  - acquire filename
//  - save the journal to a file
//  - locate the filename
//  - replace the current entries
//  - display the file journal entries

public class FileManager
{    
    // A blank array that stores the data from a file.
    public string[] _loadJournal;
    // A blamnk field that will store the user input for a filename.
    public string filename;
    // A boolean which confirms if a filename is a CSV or not.
    public bool checker;

    // A method that asks the user for a filename.
    public string GetFileName()
    {
        Console.Write($"\nWhat is the filename? ");
        // Asks for user input.
        filename = Console.ReadLine();
        // Returns the user's chosen filename.
        return filename;
    }

    // A method which asks for a filename and will check if the file is a CSV 
    // or not and returns a boolean.
    public bool FileChecker(string filename)
    {
        // A condition that checks if the provided filename has a CSV keyword.
        if (filename.Contains("csv"))
        {
            return checker = true;
        }
        else
        {
            return checker = false;
        }
    }

    // A method that asks for a filename and a list which will write into a file.
    public void SaveFile(string filename, List<string> _saveList)
    {
        // A display message before storing the entries into a file.
        Console.WriteLine($"\nSaving file....");
        
        // Instantiates the SteamWriter using the outputFile variable and uses the filename 
        // field as its file title.
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Writes each line from the list in the created file.
            foreach (string line in _saveList)
            {
                outputFile.WriteLine(line);
            }
        }
        // A confirmation indicating the process has been completed.
        Console.WriteLine($"\nFile saved.\n");
    }
    
    // A method that has a special process in storing the values into a CSV file which can
    //  be opened in Excel.
    // Has filename and a list as its parameters.
    public void SaveCsvFile(string filename, List<string> _saveList)
    {
        Console.WriteLine($"\nSaving csv file....");

        // Declares a list to store the values from the thrown list in this method.
        // Necessary for this method because each values are converted to be Excel-readable. 
        List<string> csvEntries = new List<string>();
        // Assigns the headline value to a variable for an Excel heading.
        string headline = "Date,Time,Prompt,Response";
        // Adds the headline to the created list as the first value.
        csvEntries.Add(headline);

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

    // A method that checks if the value contains a comma and then makes sure that it is 
    // not a separator/delimiter but a part of the substring.
    public string ExcelWriter(string line)
    {
        // Checks if the substring contains a comma.
        if (line.Contains(","))
        {
            // If a comma is found, creates a format and makes sure it is stored with 
            // a double quote.
            line = $"\"{line}\"";
        }
        // Returns the reformatted string.
        return line;
    }

    // A method that has filename for its parameter and reads the file, then stores it into an
    // array.
    // Contains an error catcher if the file doesn't exist.
    public string[] LoadFile(string filename)
    {
        // An introductory and confirmation message that the method has been called and will
        // start its process.
        Console.WriteLine($"Checking file....\n");
        // An error catcher which first tries if the filename exists or not.
        try
        {
            Console.WriteLine($"\nLoading file....");
            // Reads the file and uses the filename.
            _loadJournal = System.IO.File.ReadAllLines(filename);
            // A confirmation message that announces the loading of file is successful.
            Console.WriteLine($"\nFile loaded.\n");
        }
        catch (FileNotFoundException)
        {
            // Displays an error message if the file is not found within the containind folder.
            Console.WriteLine($"File not existing.\n");
        }
        // Returns the loaded strings into an array.
        return _loadJournal;
    }
}