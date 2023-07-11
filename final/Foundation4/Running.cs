using System;

public class Running : Activity
{
    public Running(int activityLength, int distance) : base (activityLength)
    {
        _distance = distance;
    }

    public override int CalculateDistance()
    {
        throw new NotImplementedException();
    }

    public override int CalculateSpeed()
    {
       _speed = (_distance / _activityLength) * 60;
       return _speed;
    }
}