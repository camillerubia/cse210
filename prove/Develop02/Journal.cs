using System;

// Responsibilities:
//  - display overall menu (write, display, load, save, quit)
//  - get user menu choice
//  - display journal entries
public class Journal 
{
    public string _journalEntry;
    public int _userInput;
    public List<string> _menuList = new List<string> {"Write", "Display", "Load", "Save", "Quit"}; 

    public FileManager _fileManager = new FileManager();
    public Entry entry = new Entry();
    

public void DisplayJournal() 
{

}

public void Menu()
{
    Console.WriteLine("Please select one of the following choices:");

    while (_userInput != 5)
    {
        for (int i = 0; i < _menuList.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_menuList[i]}");
        }

        Console.Write("What would you like to do? ");
        _userInput = int.Parse(Console.ReadLine());

        if (_userInput == 1)
        {
            entry._prompt.RandomPrompt();
        }




    }
}
}