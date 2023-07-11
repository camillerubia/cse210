using System;

public class Running : Activity
{
    public Running(int activityLength, int distance) : base (activityLength)
    {
        _distance = distance;
    }

    public override double CalculateSpeed()
    {
       _speed = (_distance / _activityLength) * 60;
       return _speed;
    }

    public override double CalculatePace()
    {
        return _pace = _activityLength / _distance;
    }
}