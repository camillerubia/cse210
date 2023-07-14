using System;

// RUNNING CLASS
// Responsibilities:
// - overrides distance, speed and pace calculator from the base class

public class Swimming : Activity
{
    // A field that stores the lap value for activity specific computation
    private int _lap;

    // A constructor that receives duration as parameter like the base with lap as an addition
    // then stores it for local use
    public Swimming(int activityLength, int lap) : base (activityLength)
    {
        _lap = lap;
    }

    // Overrides base class's calculator methods for activity specific formula
    public override double CalculateDistance()
    {
        return _distance = ((_lap * 50) / (1000 * 0.621371));
    }

    public override double CalculateSpeed()
    {
        return _speed = _distance / _activityLength;
    }

    public override double CalculatePace()
    {
        return _pace = _activityLength / _distance;
    }
}