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
        _distance = _lap * 50 / 1000;
        return _distance;
    }
}