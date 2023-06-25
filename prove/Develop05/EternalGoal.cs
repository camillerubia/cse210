using System;

// ETERNALGOAL CLASS

// Responsibilities:
// - almost similar with SimpleGoal, receives parameters as the base class to set it
//  into its own type of goal.
// - overriddes the goalstatus to set unmarked even if completed.
public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string description, int points) : base (goalName, description, points)
    {

    }

    // Overrides the inherited method to set the marker blank.
    public override string GoalStatus()
    {
        return _goalStatus = "[ ]";
    }
}