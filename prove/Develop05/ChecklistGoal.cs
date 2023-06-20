using System;

public class ChecklistGoal : Goal
{
    private int _checklistPoints;
    private int _bonusPoints;
    private int _targetGoal;

    public ChecklistGoal()
    {
        GetUserInput();
        _checklistPoints = GetPoints();
    }

    protected override void RecordEvent()
    {
    }

    protected override bool IsComplete()
    {
        return _checker;
    }

    private void FollowUp()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");

    }

}