using System;

public class EternalGoal : Goal
{
    private int _eternalPoints;

    public EternalGoal()
    {
        _goalType = "EternalGoal";
        GetUserInput();
        _eternalPoints = GetPoints();
    }

    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return _checker;
    }
}