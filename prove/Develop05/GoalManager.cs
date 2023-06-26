using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager 
{
    private List<Goal> goals;
    private int _totalPoints;
    private string _filename;
    private List<string> menuList = new List<string> {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"};
    private List<string> goalTypes = new List<string> {"Simple Goal", "Eternal Goal", "Checklist Goal"};
    private static List<Goal> goalList = new List<Goal>();
    public GoalManager()
    {
        goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void CreateGoal(int goalType)
    {
        try
        {
            Console.Clear();
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            switch (goalType)
            {
                case 1:
                    goals.Add(new SimpleGoal(goalName, description, points));
                    break;
                case 2:
                    goals.Add(new EternalGoal(goalName, description, points));
                    break;
                case 3:
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int targetGoal = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(goalName, description, points, targetGoal, bonusPoints));
                    break;
                default:
                    Console.WriteLine("Please choose within the menu options only");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.Clear();
            Console.WriteLine("Please input the correct type.");
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are:\n");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i+1}. ");
            goals[i].DisplayGoal();
        }
        Console.WriteLine();
    }

    private void GetFilename()
    {
        Console.Write("What is the filename for the goal file? ");
        _filename = Console.ReadLine();
    }

    public void SaveGoals()
    {
        GetFilename();

        using (StreamWriter writer = new StreamWriter(_filename))
        {
            // Save total points
            writer.WriteLine(_totalPoints);
            
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

                writer.WriteLine(goalData);
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        GetFilename();

        if (!File.Exists(_filename))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        using (StreamReader reader = new StreamReader(_filename))
        {
            // Read total points
            string totalPointsLine = reader.ReadLine();

            if (int.TryParse(totalPointsLine, out int totalPoints))
            {
                _totalPoints = totalPoints;
            }

            string goalLine;
            while ((goalLine = reader.ReadLine()) != null)
            {
                string[] goalData = goalLine.Split(':');

                if (goalData.Length >= 2)
                {
                    string goalType = goalData[0].Trim();
                    string[] goalParams = goalData[1].Split(',');

                    if (goalType == "SimpleGoal" && goalParams.Length >= 4)
                    {
                        string goalName = goalParams[0].Trim();
                        string goalDescription = goalParams[1].Trim();
                        int points = int.Parse(goalParams[2].Trim());
                        bool completed = bool.Parse(goalParams[3].Trim());

                        SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, points);
                        simpleGoal.SetCompleted(completed);

                        goals.Add(simpleGoal);
                    }
                    else if (goalType == "EternalGoal" && goalParams.Length >= 3)
                    {
                        string goalName = goalParams[0].Trim();
                        string goalDescription = goalParams[1].Trim();
                        int points = int.Parse(goalParams[2].Trim());

                        EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, points);

                        goals.Add(eternalGoal);
                    }
                    else if (goalType == "ChecklistGoal" && goalParams.Length >= 6)
                    {
                        string goalName = goalParams[0].Trim();
                        string goalDescription = goalParams[1].Trim();
                        int points = int.Parse(goalParams[2].Trim());
                        int bonusPoints = int.Parse(goalParams[3].Trim());
                        int targetGoal = int.Parse(goalParams[4].Trim());
                        int completedCount = int.Parse(goalParams[5].Trim());

                        ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, points, targetGoal, bonusPoints);
                        checklistGoal.SetCompletedCount(completedCount);

                        goals.Add(checklistGoal);
                    }
                }
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {goals[i].GetGoalName()}");
        }

        Console.Write("Which goal did you acccomplish? ");
        int goalIndex = int.Parse(Console.ReadLine());
        goalIndex -= 1;

        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            Goal selectedGoal = goals[goalIndex];
            selectedGoal.CompleteGoal();
            _totalPoints += selectedGoal.GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

        Console.WriteLine($"You now have {_totalPoints} points.");
    }

    public void MainMenu()
    {
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

            switch (userChoice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("The types of Goals are:\n");

                    // A loop that iterates through the List above to display in numbered format.
                    for (int i = 0; i < goalTypes.Count; i++)
                    {
                        Console.WriteLine($"{i+1}. {goalTypes[i]}");
                    }

                    Console.Write("\nWhich type of goal would you like to create? ");
                    int goalType = int.Parse(Console.ReadLine());

                    CreateGoal(goalType);
                    break;
                case 2:
                    ListGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (userChoice != 6);
    }
}