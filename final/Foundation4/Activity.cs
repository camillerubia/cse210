using System;

public abstract class Activity
{
    protected string _activityName;
    protected string _date;
    protected int _activityLength;
    protected int _distance;
    protected int _speed;
    protected int _pace;

    public Activity(string date, int activityLength)
    {

    }

    public abstract int CalculateDistance();
    public abstract int CalculateSpeed();
    public abstract int CalculatePace();
}