using System;
using System.Collections.Generic;
using System.IO;

// GOALMANAGER CLASS

// Responsibilites:
// -  manages the goals in creating, saving, loading
// - tracks each goal's progress and status
// - calculates the total points 
// - displays the main menu and the goals

public class GoalManager 
{
    // A list that would contain different types of goals.
    private List<Goal> goals;
    // A property that will store the overall score.
    private int _totalPoints;
    // A property that stores the filename from users.
    private string _filename;
    // Creates a set list for displaying menu options.
    private List<string> menuList = new List<string> {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"};
    private List<string> goalTypes = new List<string> {"Simple Goal", "Eternal Goal", "Checklist Goal"};
    
    public GoalManager()
    {
        // Initializes the list.
        goals = new List<Goal>();
        // Sets the total points to zero.
        _totalPoints = 0;
    }

    // Responsible for creating goals of different types and receives goal type as parameter
    public void CreateGoal(int goalType)
    {
        // Error catcher if the user inputs a string when program asks for points
        try
        {
            // Asks the user for goal details
            Console.Clear();
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            // A condition that decides which goal type to call and add in the list
            switch (goalType)
            {
                case 1:
                    goals.Add(new SimpleGoal(goalName, description, points));
                    break;
                case 2:
                    goals.Add(new EternalGoal(goalName, description, points));
                    break;
                // Creates follow up questions for Checklist goal type.
                case 3:
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int targetGoal = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(goalName, description, points, targetGoal, bonusPoints));
                    break;
                // Secures that the user will choose within the menu options
                default:
                    Console.WriteLine("Please choose within the menu options only");
                    break;
            }
        }
        // Error catcher, message will show letting the user know.
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine("Please input the correct type.");
        }
    }

    // Displays the goals created by the user.
    public void ListGoals()
    {
        Console.WriteLine("The goals are:\n");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i+1}. ");
            // Calls the Goal class method to display each goal line since the list is a Goal type.
            goals[i].DisplayGoal();
        }

        Console.WriteLine();
    }

    // Asks and collects the filename from the user
    private void GetFilename()
    {
        Console.Write("What is the filename for the goal file? ");
        _filename = Console.ReadLine();
    }

    // Saves the goals created into a file in their unique format.
    public void SaveGoals()
    {
        // Calls a local method to acquire the filename.
        GetFilename();
        // Instantiates the SteamWriter using the outputFile variable and uses the filename 
        // field as its file title.
        using (StreamWriter writer = new StreamWriter(_filename))
        {
            // Save total points
            writer.WriteLine(_totalPoints);
            
            // Parses through the list and calls each goal type to store details
            foreach (Goal goal in goals)
            {
                string goalData = "";

                if (goal is SimpleGoal simpleGoal)
                {
                    goalData += $"SimpleGoal: {simpleGoal.GetGoalName()}, {simpleGoal.GetDescription()}, {simpleGoal.GetPoints()}, {simpleGoal.IsCompleted()}";
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    goalData += $"EternalGoal: {eternalGoal.GetGoalName()}, {eternalGoal.GetDescription()}, {eternalGoal.GetPoints()}";
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    goalData += $"ChecklistGoal: {checklistGoal.GetGoalName()}, {checklistGoal.GetDescription()}, {checklistGoal.GetPoints()}, {checklistGoal.GetBonus()}, {checklistGoal.GetTargetGoal()}, {checklistGoal.GetCompletedCount()}";
                }

                // Writes each line from the list in the created file.
                writer.WriteLine(goalData);
            }
        }

        // Displays message when goals are saved.
        Console.WriteLine("\nGoals saved successfully!");
    }

    // Loads goals from a file.
    public void LoadGoals()
    {
        GetFilename();

        // Checks if the file with the specified name exists.
        if (!File.Exists(_filename))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        using (StreamReader reader = new StreamReader(_filename))
        {
            // Read total points and stores it in a variable.
            string totalPointsLine = reader.ReadLine();

            // Reads a line from the file for total points, tries to parse it as an int,
            // then updates the local field as a parsed value.
            if (int.TryParse(totalPointsLine, out int totalPoints))
            {
                _totalPoints = totalPoints;
            }

            string goalLine;
            while ((goalLine = reader.ReadLine()) != null)
            {
                // Split the goal line into goal type and goal parameters
                string[] goalData = goalLine.Split(':');

                if (goalData.Length >= 2)
                {
                    string goalType = goalData[0].Trim();
                    string[] goalParams = goalData[1].Split(',');

                    // Processes Simple goals and trims each string
                    if (goalType == "SimpleGoal" && goalParams.Length >= 4)
                    {
                        string goalName = goalParams[0].Trim();
                        string goalDescription = goalParams[1].Trim();
                        int points = int.Parse(goalParams[2].Trim());
                        bool completed = bool.Parse(goalParams[3].Trim());

                        // Creates a new SimpleGoal instance
                        SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, points);
                        // Accesses the method and sets the variable value for display later
                        simpleGoal.SetCompleted(completed);
                        // Adds the goal to the list
                        goals.Add(simpleGoal);
                    }
                    // Processes Eternal goals and trims each string
                    else if (goalType == "EternalGoal" && goalParams.Length >= 3)
                    {
                        string goalName = goalParams[0].Trim();
                        string goalDescription = goalParams[1].Trim();
                        int points = int.Parse(goalParams[2].Trim());

                        // Creates a new EternalGoal instance
                        EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, points);
                        // Adds the goal to the list
                        goals.Add(eternalGoal);
                    }
                    // Processes Checklist goals and trims each string
                    else if (goalType == "ChecklistGoal" && goalParams.Length >= 6)
                    {
                        string goalName = goalParams[0].Trim();
                        string goalDescription = goalParams[1].Trim();
                        int points = int.Parse(goalParams[2].Trim());
                        int bonusPoints = int.Parse(goalParams[3].Trim());
                        int targetGoal = int.Parse(goalParams[4].Trim());
                        int completedCount = int.Parse(goalParams[5].Trim());

                        // Creates a new ChecklistGoal instance
                        ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, points, targetGoal, bonusPoints);
                        // Accesses the method and sets the variable value for display later
                        checklistGoal.SetCompletedCount(completedCount);
                        // Adds the goal to the list
                        goals.Add(checklistGoal);
                    }
                }
            }
        }
        // Displays message that the goals have been loaded.
        Console.WriteLine("Goals loaded successfully!");
    }

    // Responsible for displaying created goal names and marking the them complete
    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");

        // Displays each goal from the list
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {goals[i].GetGoalName()}");
        }
        try
        {
            Console.Write("Which goal did you acccomplish? ");
            int goalIndex = int.Parse(Console.ReadLine());
            // Subtracts from the user's input to use as a local index
            goalIndex -= 1;

            // Ensures the index is within range of available goals in the list.
            if (goalIndex >= 0 && goalIndex < goals.Count)
            {
                // Retrieves the selected goal from the goals list
                Goal selectedGoal = goals[goalIndex];
                // Marks the selected goal as completed
                selectedGoal.CompleteGoal();
                // Adds the points of the completed goal to the total points
                _totalPoints += selectedGoal.GetPoints();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            // Displays the updated total points
            Console.WriteLine($"You now have {_totalPoints} points.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid choice.\n");
        }
        
    }

    // Displays the Main menu of program activities and calls the local methods and 
    // goal types accordingly.
    public void MainMenu()
    {
        // Initializes the user's choice to zero.
        int userChoice = 0;
        Console.Clear();

        //  A loop to continuously display the menu for the user.
        do
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

            // Determines the user's choice and executes actions accordingly.
            switch (userChoice)
            {
                // 1. CREATE GOAL
                case 1:
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("The types of Goals are:\n");

                        // A loop that iterates through the List above to display in numbered format.
                        for (int i = 0; i < goalTypes.Count; i++)
                        {
                            Console.WriteLine($"{i+1}. {goalTypes[i]}");
                        }

                        // Asks the user for input 
                        Console.Write("\nWhich type of goal would you like to create? ");
                        int goalType = int.Parse(Console.ReadLine());

                        CreateGoal(goalType);
                    }
                    // An error handler when the user inputs a letter and not a number.
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid choice.\n");
                    }
                    break;
                // Calls local methods to execute actions according to user's choice.
                // 2. LIST GOALS
                case 2:
                    ListGoals();
                    break;
                // 3. SAVE GOALS
                case 3:
                    SaveGoals();
                    break;
                // 4. LOAD GOALS
                case 4:
                    LoadGoals();
                    break;
                // 5. RECORD EVENT
                case 5:
                    RecordEvent();
                    break;
                // 6. QUIT
                case 6:
                    // Exits the program
                    break;
                default:
                    // Displays message when user chooses out of the menu options
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        // Loops through the menu until the user chooses to quit.
        } while (userChoice != 6);
    }
}