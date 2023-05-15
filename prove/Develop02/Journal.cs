using System;
using System.Linq;
using System.Text.RegularExpressions;

// Responsibilities:
//  - display overall menu (write, display, load, save, quit)
//  - get user menu choice
//  - display journal entries
// - call and instantiate classes and access their attributes
public class Journal 
{
    // A field to store the user's input and set its initial type as int.
    public int _userInput;
    // Pre-declared list containing the Menu to display.
    public List<string> _menuList = new List<string> {"Write", "Display", "Load", "Save", "Quit"}; 
    // Instantiates the FileManager Class and stores it into fileManager variable.
    public FileManager fileManager = new FileManager();
    // Instantiates the Entry Class and stores it into entry variable.
    public Entry entry = new Entry();
    // An empty array to store the entries.
    public string[] loadJournal;
    // An empty field for storing the filename to be passed on various class methods.
    public string filename;
    // Booleans to check certain conditions which is necessary for complex display options.
    public bool saveStatus = false;
    public bool checker;

    // A method that reads the CSV file and displays to the Console.
    public void DisplayCsvJournal(string filename)
    {
        // Reads the file and stores the values in an array. 
        string[] csvJournal = System.IO.File.ReadAllLines(filename);

        // Error catcher if the user has loaded a non-journal file.
    try
    {
            // Iterates the array, then skips the first line (header).
            foreach (string line in csvJournal.Skip(1))
            {        
                // Splits the lines with the specified pattern.
                string[] row = Regex.Split(line, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                // Makes sure that the rows contains only 4 values.
                // Will display an error message.
                if (row.Length == 4)
                {
                    // Displays the segregated values (using their indexes) with a format.
                    Console.WriteLine($"Date: {row[0]} Time: {row[1]}\nPrompt: {row[2]}\n- {row[3]}\n");
                }
            }
    }
    catch (IndexOutOfRangeException)
    {    
            // Displays an error message when the file is not a journal file.
            Console.WriteLine($"ERROR: File chosen is not a journal file.\n");
    }
    }

    // A method that handles all the Journal functions and attributes of various classes.
    public void Menu()
    {
        Console.WriteLine($"\nPlease select one of the following choices:");

        // Loops through the whole process until the user chooses to quit.
        while (true)
        {
            // Journal Menu header.
            Console.WriteLine("=== JOURNAL MENU ===");

            //  Iterates through the pre-declared list above to display options for the user.
            for (int i = 0; i < _menuList.Count; i++)
            {
                // Displays menu with incrementing numbers at the left side.
                Console.WriteLine($"{i+1}. {_menuList[i]}");
            }

            // Error catcher when the user enters a letter instead of a number.
            try 
            {
                // Asks for the user input.
                Console.Write($"\nWhat would you like to do? ");
                _userInput = int.Parse(Console.ReadLine());
            }

            catch (FormatException)
            {
                // Shows the error message when user enters a string.
                Console.WriteLine("Invalid choice.");
            }

            // 1. WRITE
            if (_userInput == 1)
            {
                // Calls the Entry Class method to initialize entry input from the user.
                entry.InputEntry();
                // Saves each entry into the singleEntry attribute of the Entry class.
                entry._singleEntry = entry.JournalEntry();
                // Adds the attribute to the entryList declared inside the Entry Class.
                entry._entryList.Add(entry._singleEntry);
                // Sets the boolean to false as user haven't chose to save entries yet.
                saveStatus = false;
                // Calls the SeparateEntries method from the Entry Class.
                // Adds the separated entry variables into a different list for CSV file.
                entry._csvList.Add(entry.SeparateEntries());
            } 

            // 2. DISPLAY
            if (_userInput == 2) 
            {
                Console.WriteLine();

                // Various display options which depends on the boolean value.
                if (saveStatus == false)
                {
                    // Iterates and displays each line of entries in the entryList when 
                    // user haven't saved the entries yet.
                    foreach (string line in entry._entryList)
                    {
                        Console.WriteLine(line);
                    }
                } 
                else 
                {
                    // Calls the FileManager method to check if the file has been loaded as CSV file.
                    checker = fileManager.FileChecker(filename);
                    // If the boolean is true, calls the Journal Class method to read, separate and
                    // display from the CSV file.
                    if (checker == true)
                    {
                        DisplayCsvJournal(filename);
                    } 
                    else 
                    {
                        // Iterates and displays the values inside an array: especially if the file
                        // ia not saved as CSV.
                        foreach (string line in loadJournal)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }      
                Console.WriteLine();
            } 

            // 3. LOAD
            if (_userInput == 3) 
            {
                // Calls the FileManager method to acquire the filename from the user.
                filename = fileManager.GetFileName();
                // Calls the LoadFile method from the FileManager class and provides the filename
                // from the GetFileName method.
                loadJournal = fileManager.LoadFile(filename);
                // Confirms that the user has chosen a pre-saved file.
                saveStatus = true;          
            } 

            // 4. SAVE
            if (_userInput == 4) 
            {
                // Calls the FileManager method to acquire the filename from the user.
                filename = fileManager.GetFileName();
                // Calls the FileChecker method from the FileManager Class to identify the file type
                // which returns a boolean value.
                checker = fileManager.FileChecker(filename);

                // Conditions set in saving different file types.
                if (checker == true)
                {
                    // Calls the SaveCsvFile method from the FileManager Class if user has chosen 
                    // to save entries as CSV file and throws the csvList which contains separate
                    // values: (date, time, prompt and response).
                    fileManager.SaveCsvFile(filename, entry._csvList);
                } else {
                    // Calls the simple method from the FileManager Class and throws the entryList
                    // from Entry Class which contains formatted date, time, prompt and response 
                    // in one row.
                    fileManager.SaveFile(filename, entry._entryList);
                }
            } 

            // 5. QUIT
            if (_userInput == 5) 
            {
                // Confirms if user agrees with exiting the program.
                Console.WriteLine("NOTE: Please make sure all changes has been saved.");
                Console.WriteLine("All unsaved progress will be lost.");
                Console.Write("Are you sure you want to quit? (y or n): ");
                // User input for exit confirmation.
                string confirmation = Console.ReadLine();

                // Breaks the loop if the user answers "y".
                if (confirmation == "y")
                {
                    break;
                } 
                // Calls the Menu method from the Journal Class again to
                // display the menu options
                if (confirmation == "n")
                {
                    Menu();
                } 
                else 
                {
                    // Error message when user inputs neither y or n.
                    // Then loop continues if user inputs a number.
                    Console.WriteLine($"Invalid choice. (y) or (n) only.\n");
                }
            } 

            // Displays message when user choice is out of 1-5 range.
            else if (_userInput > 5) 
            {
                Console.WriteLine($"Please choose numbers 1-5 only.\n");
            }
        }
    }
}