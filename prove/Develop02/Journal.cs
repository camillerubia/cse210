using System;

// Responsibilities:
//  - display overall menu (write, display, load, save, quit)
//  - get user menu choice
//  - display journal entries
public class Journal 
{
    public string _journalEntry;
    public int _userInput;
    public int displayCount = 0;
    public string[] journalArray;
    public List<string> _menuList = new List<string> {"Write", "Display", "Load", "Save", "Quit"}; 

    public FileManager _fileManager = new FileManager();
    public Entry entry = new Entry();
    

public void DisplayJournal() 
{

}

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

        } else if (_userInput == 2) {

            foreach (string line in entry._entryList)
            {
                Console.WriteLine("hey");
                Console.WriteLine(line);
            }

        } else if (_userInput == 5) {
            break;
        } else {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }


}
}