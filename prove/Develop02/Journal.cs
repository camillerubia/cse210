using System;
using System.Linq;

// Responsibilities:
//  - display overall menu (write, display, load, save, quit)
//  - get user menu choice
//  - display journal entries
public class Journal 
{
    public int _userInput;
    public List<string> _menuList = new List<string> {"Write", "Display", "Load", "Save", "Quit"}; 

    public FileManager fileManager = new FileManager();
    public Entry entry = new Entry();
    public bool saveStatus = false;
    public string[] loadJournal;
    public string filename;
    public bool checker;

public void DisplayCsvJournal(string filename)
{
   string[] csvJournal = System.IO.File.ReadAllLines(filename);

   try
   {
        foreach (string line in csvJournal)
        {
            string[] row = line.Split('~');
            Console.WriteLine($"Date: {row[0]} Time: {row[1]}\nPrompt: {row[2]}\n- {row[3]}\n");
        }
   }
   catch (IndexOutOfRangeException)
   {    
        Console.WriteLine($"ERROR: File chosen is not a journal file.\n");
   }

   
}
public void Menu()
{
    Console.WriteLine("Please select one of the following choices:");

    while (true)
    {
        Console.WriteLine("=== JOURNAL MENU ===");
        for (int i = 0; i < _menuList.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_menuList[i]}");
        }

        Console.Write($"\nWhat would you like to do? ");

        try 
        {
            _userInput = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid choice.");
        }
        // Write
        if (_userInput == 1)
        {
            entry.InputEntry();
            entry._singleEntry = entry.JournalEntry();
            entry._entryList.Add(entry._singleEntry);
            saveStatus = false;

            entry._csvList.Add(entry.SeparateEntries());

        //  Display
        } else if (_userInput == 2) 
        {
            Console.WriteLine();
            
            if (saveStatus == false)
            {
                foreach (string line in entry._entryList)
                {
                    Console.WriteLine(line);
                }
            } else {
                checker = fileManager.FileChecker(filename);
                
                if (checker == true)
                {
                    DisplayCsvJournal(filename);
                } else {
                    foreach (string line in loadJournal)
                    {
                        Console.WriteLine(line);
                    }
                }
            }             
            Console.WriteLine();
        
        // Load
        } else if (_userInput == 3) {
            filename = fileManager.GetFileName();
            loadJournal = fileManager.LoadFile(filename);
            saveStatus = true;          
        
        // Save
        } else if (_userInput == 4) {
            filename = fileManager.GetFileName();
            checker = fileManager.FileChecker(filename);
            
            if (checker == true)
            {
                fileManager.SaveCsvFile(filename, entry._csvList);
            } else {
                fileManager.SaveFile(filename, entry._entryList);
            }
        
        // Quit
        } if (_userInput == 5) {
            Console.WriteLine("All unsaved progress will be lost.");
            Console.Write("Are you sure you want to quit? (y or n): ");
            string confirmation = Console.ReadLine();

            if (confirmation == "y")
            {
                // Menu();
                break;
                
            } if (confirmation == "n") {
                // break;
                Menu();
            } else {
                Console.WriteLine($"Invalid choice. (y) or (n) only.\n");
            }
            
        } else {
                Console.WriteLine($"Please choose numbers 1-5 only.\n");
            }
        }
    }
}