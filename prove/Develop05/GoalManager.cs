using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager 
{
    private List<Goal> goals;
    private int _totalPoints;
    private string _filename;

    public GoalManager()
    {
        goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void CreateGoal(int goalType)
    {
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

    public void ListGoals()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i+1}. ");
            goals[i].DisplayGoal();
        }
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
            foreach (Goal goal in goals)
            {
                string goalData = $"{goal.GetPoints()}";

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
}