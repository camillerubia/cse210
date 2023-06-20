using System;

public class SimpleGoal : Goal
{
    private int _simplePoints;

    public SimpleGoal()
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
     return _simplePoints;
    }

}