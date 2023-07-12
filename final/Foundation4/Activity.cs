using System;

public abstract class Activity
{
    protected string _activityName;
    static DateTime dateNow = DateTime.Now;
    protected string _date = dateNow.ToString("d MMMM yyyy");
    protected int _activityLength;
    protected float _distance;
    protected float _speed;
    protected float _pace;
    protected string _activityType;

    public Activity(int activityLength)
    {
        _activityLength = activityLength;
        _activityType = GetType().Name;
    }

    public virtual float CalculateDistance()
    {
        return _distance;
    }
    public virtual float CalculateSpeed()
    {
        return _speed = 60 / _pace;
    }
    public virtual float CalculatePace()
    {
        return _pace = 60 / _speed;
    }

    public void GetSummary()
    {
        CalculateDistance();
        CalculateSpeed();
        CalculatePace();
        Console.WriteLine($"\n{_date} {_activityType} ({_activityLength}) min - Distance: {_distance} miles, Speed: {_speed} mph, Pace: {_pace} min per mile");
    }
}