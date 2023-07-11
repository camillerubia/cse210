using System;

public abstract class Activity
{
    protected string _activityName;
    static DateTime dateNow = DateTime.Now;
    protected string _date = dateNow.ToString();
    protected int _activityLength;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected string _activityType;

    public Activity(int activityLength)
    {
        _activityLength = activityLength;
        _activityType = GetType().Name;
    }

    public virtual double CalculateDistance()
    {
        return _distance;
    }
    public virtual double CalculateSpeed()
    {
        return _speed = 60 / _pace;
    }
    public virtual double CalculatePace()
    {
        return _pace = 60 / _speed;
    }

    public void GetSummary()
    {
        CalculateDistance();
        CalculateSpeed();
        CalculatePace();
        Console.WriteLine($"{_date} {_activityType} ({_activityLength}) - Distance: {_distance} miles, Speed: {_speed} mph, Pace: {_pace} min per mile");
    }
}