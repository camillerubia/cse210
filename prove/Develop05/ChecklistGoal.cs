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
        FollowUp();
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
        _targetGoal = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

}