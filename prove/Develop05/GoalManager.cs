using System;
using System.Collections.Generic;
using System.Xml.Serialization;

public class GoalManager : Goal
{
    // Creates a set list for displaying menu options.
    private List<string> menuList = new List<string> {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"};
    private List<string> goalType = new List<string> {"Simple Goal", "Eternal Goal", "Checklist Goal"};
    private List<string> goalNames = new List<string>();
    private List<int> goalPoints = new List<int>();

    FileManager manager = new FileManager();
    private static int bonus;
    private static int target;
    private static int completeTarget;
    
    
    public GoalManager()
    {
        DisplayMenu();
    }

    
    private void GoalType()
    {
        int userGoalType = 0;
        Console.Clear();
        
        Console.WriteLine("The type of Goals are:");

        // A loop that iterates through the List above to display in numbered format.
        for (int i = 0; i < goalType.Count; i++)
        {
            Console.WriteLine($"{i+1}. {goalType[i]}");
        }

        try
        {
            // Gets the user input.
            Console.Write("\nWhich type of goal would you like to create? ");
            userGoalType = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        // An error handler when the user inputs a letter and not a number.
        catch (FormatException)
        {
            Console.WriteLine("Invalid choice.\n");
        }

        if (userGoalType == 1)
        {
            SimpleGoal simple = new SimpleGoal();
        }

        if (userGoalType == 2)
        {
            EternalGoal eternal = new EternalGoal();
        }

        if (userGoalType == 3)
        {
            ChecklistGoal checklist = new ChecklistGoal();
            bonus = checklist.GetBonus();
            target = checklist.GetTarget();
            completeTarget = checklist.GetCompleteTarget();
        }
    }

    private void DisplayMenu()
    {
        // Initializes the user input to 0.
        int userChoice = 0;
        Console.Clear();

        //  A loop to continuously display the menu for the user.
        while (true)
        {
            Console.WriteLine($"You have {_totalPoints} total points.\n");

            Console.WriteLine("Menu Options:");

            // A loop that iterates through the List above to display in numbered format.
            for (int i = 0; i < menuList.Count; i++)
            {
                Console.WriteLine($"{i+1}. {menuList[i]}");
            }
        
            try
            {
                // Gets the user input.
                Console.Write("\nSelect a choice from the menu: ");
                userChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            // An error handler when the user inputs a letter and not a number.
            catch (FormatException)
            {
                Console.WriteLine("Invalid choice.\n");
            }

            // If conditions for each user choice from the menu which instantiates each sublass to perform their functionalities.
            // Also contains counters for each activities to use in the LogManager Class later.

            // 1. GOAL TYPES
            if (userChoice == 1)
            {
                GoalType();
            }

             // 2. LIST GOALS
            if (userChoice == 2)
            {
                for (int i = 0; i < Goal._goalList.Count; i++)
                {
                    string goalLine = Goal._goalList[i];
                    string[] goalComponents = goalLine.Split(',');
                    _goalType = goalComponents[0].Trim();
                    _complete = goalComponents[1].Trim();
                    _goalName = goalComponents[2].Trim();
                    _description = goalComponents[3].Trim();
                    _points = int.Parse(goalComponents[4].Trim());
                    goalNames.Add(_goalName);
                    goalPoints.Add(_points);

                    if (_goalType == "ChecklistGoal")
                    {
                        Console.WriteLine($"{i + 1}. [{_complete}] {_goalName} ({_description}) -- Currently completed: {completeTarget}/{target}");
                    }

                    else
                    {
                        Console.WriteLine($"{i + 1}. [{_complete}] {_goalName} ({_description})");
                    } 
                }

                Console.WriteLine();
            }
            // 3. SAVE GOAL
            if (userChoice == 3)
            {
                manager.SaveFile(); 
            }

            // 4. LOAD GOAL
            if (userChoice == 4) 
            {
                manager.LoadFile(); 
            }

            // 5. RECORD EVENT
            if (userChoice == 5)
            {
                RecordEvent();
            }

            // 6. QUIT
            if (userChoice == 6)
            {
                break;
            }

            // Displays message when user choice is out of 1-6 range.
            else if (userChoice > 6) 
            {
                Console.WriteLine($"Please choose numbers 1-6 only.\n");
            }
        }
    }

    public override void RecordEvent()
    {
        Console.WriteLine("The goals are");
        for (int i = 0; i < goalNames.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goalNames[i]}");
        }
        goalNames.Clear();

        Console.WriteLine("Which goal did you accomplish? ");
        int userChoice = int.Parse(Console.ReadLine());
        int index = userChoice -1;
        string goalName = goalNames[index];
        int goalPoint = goalPoints[index];
        
        if (_goalList[index].Contains("SimpleGoal"))
        {
            SimpleGoal simple = new SimpleGoal(true, goalName);
        }
        
        _totalPoints += goalPoint;

        Console.WriteLine($"Congratulations! You have earned {goalPoint} points!");
        Console.WriteLine($"You now have {_totalPoints}.");
    }

    public override bool IsComplete()
    {
        return _checker;
    }
}