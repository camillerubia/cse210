using System;

public abstract class Activity
{
    protected string _activityName;
    static DateTime dateNow = DateTime.Now;
    protected string _date = dateNow.ToString("d MMMM yyyy");
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
        Console.WriteLine($"\n{_date} {_activityType} ({_activityLength}) min - Distance: {_distance.ToString("0.0")} miles, Speed: {_speed.ToString("0.00")} mph, Pace: {_pace.ToString("0.0")} min per mile");
    }
}