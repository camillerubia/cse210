using System;

public class SimpleGoal : Goal
{
    private int _simplePoints;

    public SimpleGoal()
    {
        _goalType = "SimpleGoal";
        GetUserInput();
        
    }

    public SimpleGoal(bool checker, string goalName)
    {
        _checker = checker;
        _goalName = goalName;
        RecordEvent();
    }

    public override void RecordEvent()
    {
        _simplePoints = GetPoints();
        _totalPoints += _simplePoints;

        Completed(_checker);

        for (int i = 0; i < _goalList.Count; i++)
        {
            if (_goalList[i].Contains(_goalName))
            {
                string[] parts = _goalList[i].Split(',');
                parts[1] = _complete;
                _goalList[i] = string.Join(",", parts);
            }
        }
    }

    public override bool IsComplete()
    {
        _checker = true;
        return _checker;
    }

    private string Completed(bool checker)
    {
        if (checker)
        {
            return _complete = "X";
        }
        else
        {
            return _complete;
        }
    }
}