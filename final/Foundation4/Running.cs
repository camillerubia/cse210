using System;

public class Running : Activity
{
    public Running(string date, int activityLength) : base (date, activityLength)
    {

    }

    public override int CalculateDistance()
    {
        throw new NotImplementedException();
    }

    public override int CalculateSpeed()
    {
        throw new NotImplementedException();
    }

    public override int CalculatePace()
    {
        throw new NotImplementedException();
    }
}