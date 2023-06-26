using System;

// GOAL CLASS
// Responsibilities:

// - initialize base property values for child classes's use
// - sets the uniform (but can be overridden) goal display format for each goal type.

public abstract class Goal
{
    // Shared properties that will be used by each child classes.
    protected string _goalName;
    protected string _description;
    protected int _points;
    // A boolean that will confirm if a single goal has been completed or not.
    protected bool _completed;
    // A marker that displays if the goal has been completed or not.
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
        // // A ternary operator that determines the goal status based on its completion.
        string goalStatus = _completed ? "[X]" : "[ ]";
        Console.WriteLine($"{goalStatus} {_goalName} ({_description})");
    }

    // Marks the boolean to true when method is called and displays message.
    public virtual void CompleteGoal()
    {
        _completed = true;
        Console.WriteLine($"\nCongratulations! You have earned {_points} points!\n");
    }

    // Allows external source to access the points, goal name and description for each goal type.
    public int GetPoints()
    {
        return _points;
    }

    public  string GetGoalName()
    {
        return _goalName;
    }

    public  string GetDescription()
    {
        return _description;
    }
}