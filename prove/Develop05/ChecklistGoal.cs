using System;

// CHECKLISTGOAL CLASS

// Responsibilities:
// - receives parameters as the base class to set it into its own type of goal.
// - overrides some methods for its specific way of displaying completed goals.

public class ChecklistGoal : Goal
{
    // Creates specific properties for this goal
    private int _targetGoal;
    private int _bonusPoints;
    private int _completedCount;

    // Receives parameters and sets it into its own use
    // Initializes the completed count to zero.
    public ChecklistGoal(string goalName, string description, int points, int targetGoal, int bonusPoints) : base (goalName, description, points)
    {
        _targetGoal = targetGoal;
        _bonusPoints = bonusPoints;
        _completedCount = 0;
    }

    // Overrides the inherited method to display specific goal type format.
    public override void DisplayGoal()
    {
        string goalStatus = base.GoalStatus();
        Console.WriteLine($"{goalStatus} {_goalName} ({_description}) -- Currently completed: {_completedCount}/{_targetGoal}");
    }

    // Overrides the inherited method to add the bonus points to the goal point and to display
    // target goal and completed goal count
    public override void CompleteGoal()
    {
        _completedCount++;

        if (_completedCount == _targetGoal)
        {
            _completed = true;
            int totalPoints = _points + _bonusPoints;

            Console.WriteLine($"Congratulations! You have earned {totalPoints} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        }
    }

    public int GetTargetGoal()
    {
        return _targetGoal;
    }

    public int GetBonus()
    {
        return _bonusPoints;
    }

    public int GetCompletedCount()
    {
        return _completedCount;
    }
}