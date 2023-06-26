using System;

// ETERNALGOAL CLASS

// Responsibilities:
// - almost similar with SimpleGoal, receives parameters as the base class to set it
//  into its own type of goal.
// - overriddes the goalstatus to set unmarked even if completed.
public class EternalGoal : Goal
{
    // Sets parameters for class constructor
    public EternalGoal(string goalName, string description, int points) : base (goalName, description, points)
    {

    }

    // Overrides the inherited method to set the marker blank.
    public override void DisplayGoal()
    {
        string goalStatus = "[ ]";
        Console.WriteLine($"{goalStatus} {_goalName} ({_description})");
    }
}