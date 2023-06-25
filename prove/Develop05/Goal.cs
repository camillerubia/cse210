using System;
using System.Collections.Generic;

public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points;
    protected bool _completed;
    public string _goalStatus;

    // Initialize the values of each property with specific values 
    // when a class instantiation is created.
    public Goal(string goalName, string description, int points)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
        _completed = false;
    }

    // Displays each goal when user chooses List Goal option in the main menu.
    public virtual void DisplayGoal()
    {
        string goalStatus = GoalStatus();
        Console.WriteLine($"{goalStatus} {_goalName} ({_description})");
    }

    public virtual void CompleteGoal()
    {
        _completed = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual string GoalStatus()
    {
        if (_completed)
        {
            _goalStatus = "[X]";
        }
        else
        {
            _goalStatus = "[ ]";
        }

        return _goalStatus;
    }

}