using System;

// CYCLING CLASS
// Responsibilities:
// - overrides distance, speed and pace calculator from the base class

public class Cycling : Activity
{
    // A constructor that receives speed as parameter like the base with the distance as an addition
    // then stores it for local use
    public Cycling(int activityLength, int speed) : base (activityLength)
    {
        _speed = speed;
    }

    // Overrides base class's calculator methods for activity specific formula
    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return _pace = 60 / _speed;
    }

    public override double CalculateDistance()
    {
        return _distance = (_speed / 60) * _activityLength;
    }    
}