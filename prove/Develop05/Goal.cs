using System;
using System.Collections.Generic;

public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _points;
    protected bool _completed;

    public virtual void DisplayGoal()
    {

    }

    public virtual void IsComplete()
    {

    }

    public int GetPoints()
    {
        return _points;
    }

}