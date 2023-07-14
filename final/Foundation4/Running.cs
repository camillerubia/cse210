using System;

// RUNNING CLASS
// Responsibilities:
// - overrides distance, speed and pace calculator from the base class

public class Running : Activity
{
    // A constructor that receives duration as parameter like the base with the distance as an addition
    // then stores it for local use
    public Running(int activityLength, int distance) : base (activityLength)
    {
        _distance = distance;
    }

    // Overrides base class's calculator methods for activity specific formula
    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculateSpeed()
    {
       return _speed = (_distance / _activityLength) * 60;
    }

    public override double CalculatePace()
    {
        return _pace = _activityLength / _distance;
    }
}