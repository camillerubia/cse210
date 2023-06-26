using System;
// Stretch
// - Error handling

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        // Instantiates the GoalManager class then calls its method to run the program.
        GoalManager goalManager = new GoalManager();
        goalManager.MainMenu();
    }
}