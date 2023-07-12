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
        _distance = _lap * 50 / 1000f;
        return _distance;
    }
}