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
        throw new NotImplementedException();
    }

    protected override void DisplayGoals()
    {
        throw new NotImplementedException();
    }

    protected override string GetUserInput()
    {
        throw new NotImplementedException();
    }

    protected override int GetPoints()
    {
        throw new NotImplementedException();
    }

}