using System;

public class GoalMenu
{
    // Creates a set list for displaying menu options.
    private List<string> menuList = new List<string> {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"};
    private List<string> goalType = new List<string> {"Simple Goal", "Eternal Goal", "Checklist Goal"};
    GoalManager manager = new GoalManager();
    List<string> goalList = new List<string>();
    private string goalName;
    private string description;
    private int points;
    private string complete;
    
    public GoalMenu()
    {
        DisplayMenu();
    }

    private void DisplayMenu()
    {
        // Initializes the user input to 0.
        int userChoice = 0;
        Console.Clear();

        //  A loop to continuously display the menu for the user.
        while (true)
        {
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
                SimpleGoal
                goalList = simple.GetList();

                Console.WriteLine(goalList.Count);
                // foreach (string goalLine in goalList)
                // {
                //     string[] goalComponents = goalLine.Split(',');
                //     complete = goalComponents[0].Trim();
                //     goalName = goalComponents[1].Trim();
                //     description = goalComponents[2].Trim();
                //     points = int.Parse(goalComponents[3].Trim());
                // }

                // Console.WriteLine("The goals are:");

                // for (int i = 0; i < goalList.Count; i++)
                // {
                //     Console.WriteLine($"{i+1}. [{complete}] {goalName} ({description})");
                // }
            }

            //  // 3. LISTING
            // if (userChoice == 3)
            // {
            //     ListingActivity listing = new ListingActivity();  
            //     logmanager._listingCounter ++;    
            // }

            // // 4. SUMMARY
            // if (userChoice == 4) 
            // {
            //     Console.Clear();
            //     // Calls the method to display the log options (display, save and load) for the user.
            //     logmanager.DisplayLogOptions();
            //     // A buffer to wait before the Menu options show up again which will clear the console after.
            //     string buffer = Console.ReadLine();
            //     Console.Clear();
            // }

            // 6. QUIT
            if (userChoice == 6)
            {
                break;
            }

            // Displays message when user choice is out of 1-5 range.
            else if (userChoice > 5) 
            {
                Console.WriteLine($"Please choose numbers 1-5 only.\n");
            }
        }
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
        }
    }
}