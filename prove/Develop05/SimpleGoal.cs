using System;

public class SimpleGoal : Goal
{
    private int _simplePoints;

    public SimpleGoal()
    {
        _goalType = "SimpleGoal";
        GetUserInput();
        
    }

    public SimpleGoal(bool checker)
    {
        RecordEvent();
    }

    protected override void RecordEvent()
    {
        _simplePoints = GetPoints();
    }

    protected override bool IsComplete()
    {
        return _checker;
    }

}