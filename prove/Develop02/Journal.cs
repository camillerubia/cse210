using System;

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
    string[] loadJournal;
    public string filename;
    
public void Menu()
{
    Console.WriteLine("Please select one of the following choices:");

    while (true)
    {
        for (int i = 0; i < _menuList.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_menuList[i]}");
        }

        Console.WriteLine();
        Console.Write("What would you like to do? ");
        _userInput = int.Parse(Console.ReadLine());

        if (_userInput == 1)
        {
            entry.InputEntry();
            entry._singleEntry = entry.JournalEntry();
            entry._entryList.Add(entry._singleEntry);
            saveStatus = false;

        } else if (_userInput == 2) 
        {
            Console.WriteLine();

            if (saveStatus == false)
            {
                foreach (string line in entry._entryList)
                {
                    Console.WriteLine(line);
                    Console.WriteLine();
                }
            } else {
                foreach (string line in loadJournal)
                {
                    Console.WriteLine(line);
                    Console.WriteLine();
                }
            }   

        } else if (_userInput == 3) {
            filename = fileManager.GetFileName();
            loadJournal = fileManager.LoadFile(filename);
            saveStatus = true;

        } else if (_userInput == 4) {
            filename = fileManager.GetFileName();
            fileManager.SaveFile(filename, entry._entryList);
            
        } else if (_userInput == 5) {
            break;
        } else {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}
}