using System;

// SIMPLEGOAL CLASS

// Responsibilities:
// - receives parameters as the base class to set it into its own type of goal.
public class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string description, int points) : base (goalName, description, points)
    {

    }

    public bool IsCompleted()
    {
        return _completed;
    }
}