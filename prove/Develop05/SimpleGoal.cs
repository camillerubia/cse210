using System;

// SIMPLEGOAL CLASS

// Responsibilities:
// - receives parameters as the base class to set it into its own type of goal.
public class SimpleGoal : Goal
{
    // Sets parameters for class constructor
    public SimpleGoal(string goalName, string description, int points) : base (goalName, description, points)
    {

    }

    // Returns the goal status for external access. (used for saving in a file)
    public bool IsCompleted()
    {
        return _completed;
    }

    // Allows external access to set the goal status. (used for saving in a file)
    public void SetCompleted(bool completed)
    {
        _completed = completed;
    }
}