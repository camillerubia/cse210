using System;

public class Cycling : Activity
{
    public Cycling(int activityLength, int speed) : base (activityLength)
    {
        _speed = speed;
    }

    public override int CalculateDistance()
    {
        throw new NotImplementedException();
    }

    public override int CalculateSpeed()
    {
        throw new NotImplementedException();
    }
}