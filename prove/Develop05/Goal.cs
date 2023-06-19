using System;
using System.Collections.Generic;

public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _totalPoints;
    protected bool _checker;
    protected List<string> _goalList = new List<string>();

    protected abstract void RecordEvent();
    protected abstract bool IsComplete();
    protected abstract void DisplayGoals();
    protected abstract string GetUserInput();
    protected abstract int GetPoints();

}