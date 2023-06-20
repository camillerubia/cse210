using System;

public class EternalGoal : Goal
{
    private int _eternalPoints;

    public EternalGoal()
    {

    }

    protected override void RecordEvent()
    {
    }

    protected override bool IsComplete()
    {
        return _checker;
    }

    protected override void DisplayGoals()
    {
        
    }

    protected override string GetUserInput()
    {
        return _userInput;
    }

    protected override int GetPoints()
    {
     return _eternalPoints;
    }

}