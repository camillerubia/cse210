using System;

public class Swimming : Activity
{
    private int _lap;
    public Swimming(int activityLength, int lap) : base (activityLength)
    {
        _lap = lap;
    }

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