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

    public override void RecordEvent()
    {
        _simplePoints = GetPoints();

        if (_goalList.Contains("SimpleGoal"))
        {
            _checker = true;
        }
    }

    public override bool IsComplete()
    {
        return _checker;
    }

}