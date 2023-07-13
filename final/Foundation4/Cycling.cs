using System;

public class Cycling : Activity
{
    public Cycling(int activityLength, int speed) : base (activityLength)
    {
        _speed = speed;
    }

    public override float CalculateSpeed()
    {
        return _speed;
    }

    public override float CalculateDistance()
    {
        return _distance = _speed * _activityLength;
    }
}