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
        return _checker;
    }


}