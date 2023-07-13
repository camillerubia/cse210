using System;

public class Running : Activity
{
    public Running(int activityLength, int distance) : base (activityLength)
    {
        _distance = distance;
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