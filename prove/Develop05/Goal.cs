using System;
using System.Collections.Generic;

public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected string _userInput;
    protected int _menuChoice;
    protected int _totalPoints;
    protected bool _checker;
    protected List<string> _goalList = new List<string>();

    protected abstract void RecordEvent();
    protected abstract bool IsComplete();


    protected void DisplayGoals()
    {

    }
    protected string GetUserInput()
    {
        return _userInput;
    }
    protected int GetPoints()
    {
        int points = 0;
        return points;
    }

}