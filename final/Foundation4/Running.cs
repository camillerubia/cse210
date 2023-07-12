using System;

public class Running : Activity
{
    public Running(int activityLength, int distance) : base (activityLength)
    {
        _distance = distance;
    }

    public override float CalculateSpeed()
    {
       _speed = (_distance / _activityLength) * 60;
       return _speed;
    }

    public override float CalculatePace()
    {
        return _pace = _activityLength / _distance;
    }
}