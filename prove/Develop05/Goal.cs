using System;
using System.Collections.Generic;

public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected string _userInput;
    protected int _menuChoice;
    protected int _totalPoints;
    protected int _points;
    protected bool _checker;
    private string _complete;
    protected List<string> _goalList = new List<string>();

    protected abstract void RecordEvent();
    protected abstract bool IsComplete();


    protected void DisplayGoals()
    {
        if (_checker)
        {
            _complete = "X";
        }
    }

    protected void GetUserInput()
    {
        Console.Clear();
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        string goalLine = $"{_complete}, {_goalName}, {_description}, {_points.ToString()}";
        _goalList.Add(goalLine);
    }
    protected int GetPoints()
    {
        // Console.Write("What is the amount of points associated with this goal? ");
        // int points = int.Parse(Console.ReadLine());
        int points = 0;
        return points;
    }

    

}