using System;

public class Swimming : Activity
{
    private int _lap;
    public Swimming(int activityLength, int lap) : base (activityLength)
    {
        _lap = lap;
    }

    public override float CalculateDistance()
    {
        return _distance = _lap * 50 / 1000;
    }

    public override float CalculateSpeed()
    {
        return _speed = _distance / _activityLength;
    }

    public override float CalculatePace()
    {
        return _pace = _activityLength / _distance;
    }
}