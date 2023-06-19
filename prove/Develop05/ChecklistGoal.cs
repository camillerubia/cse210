using System;

public class ChecklistGoal : Goal
{
    private int _checklistPoints;
    private int _bonusPoints;
    private int _targetGoal;

    public ChecklistGoal()
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