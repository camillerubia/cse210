using System;

public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string description, int points) : base (goalName, description, points)
    {

    }

    public override string GoalStatus()
    {
        return _goalStatus = "[ ]";
    }
}