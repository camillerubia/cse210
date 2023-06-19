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