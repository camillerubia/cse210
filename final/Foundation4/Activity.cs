using System;

public abstract class Activity
{
    protected string _activityName;
    static DateTime dateNow = DateTime.Now;
    protected string _date = dateNow.ToShortDateString();
    protected int _activityLength;
    protected int _distance;
    protected int _speed;
    protected int _pace;
    protected string _activityType;

    public Activity(int activityLength)
    {
        _activityLength = activityLength;
        _activityType = GetType().Name;
    }

    public abstract int CalculateDistance();
    public abstract int CalculateSpeed();
    protected int CalculatePace()
    {
        return _pace = 60 / _speed;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityType} - Distance: {_distance}km, Speed {_speed}mph, Pace {_pace}min per km");
    }
}