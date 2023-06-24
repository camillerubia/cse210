using System;
using System.Collections.Generic;

public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected string _userInput;
    protected string _goalType;
    protected int _menuChoice;
    protected int _totalPoints;
    protected int _points;
    protected bool _checker;
    protected string _complete;
    protected static List<string> _goalList = new List<string>();

    protected abstract void RecordEvent();
    protected abstract bool IsComplete();

    protected void GetUserInput()
    {

        try
        {
            Console.Clear();
            Console.Write("What is the name of your goal? ");
            _goalName = Console.ReadLine();
        }
        catch (FormatException)
        {
            Console.WriteLine("Please input the correct type.");
        }
            Console.Write("What is a short description of it? ");
            _description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            _points = int.Parse(Console.ReadLine());
            string goalLine = $"{_goalType}, {_complete}, {_goalName}, {_description}, {_points.ToString()}";
            Goal._goalList.Add(goalLine);

        
        
    }
    protected int GetPoints()
    {
        // Console.Write("What is the amount of points associated with this goal? ");
        // int points = int.Parse(Console.ReadLine());
        int points = 0;
        return points;
    }

}