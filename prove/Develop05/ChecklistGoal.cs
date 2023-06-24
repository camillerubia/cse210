using System;

public class ChecklistGoal : Goal
{
    private int _checklistPoints;
    private int _bonusPoints;
    private int _targetGoal;
    private int _completeTarget;

    public ChecklistGoal()
    {
        _goalType = "ChecklistGoal";
        GetUserInput();
        FollowUp();
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
        _targetGoal = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public int GetBonus()
    {
        return _bonusPoints;
    }

    public int GetTarget()
    {
        return _targetGoal;
    }

    public int GetCompleteTarget()
    {
        return _completeTarget;
    }

}