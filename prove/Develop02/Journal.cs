using System;

// Responsibilities:
//  - display overall menu (write, display, load, save, quit)
//  - get user menu choice
//  - display journal entries
public class Journal 
{
    public string _journalEntry;
    public string _userInput;
    public int _menuCount = 1;
    public List<string> _menuList = new List<string> {"Write", "Display", "Load", "Save", "Quit"}; 

public void DisplayJournal() 
{

}

public void Menu()
{
    Console.WriteLine("Please select one of the following choices:");

    for (int i = 1; i < _menuList.Count; i++)
    {
       Console.WriteLine($"{i}. {_menuList[i]}");
    }
}
}