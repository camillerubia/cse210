using System;

public class Cycling : Activity
{
    public Cycling(int activityLength, int speed) : base (activityLength)
    {
        _speed = speed;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculateDistance()
    {
        return _distance = (_speed / 60) * _activityLength;
    }
}