using System;

// ACTIVITY CLASS
// Responsibilities:
// - store activity name, date, duration, distance, speed, pace and activity type
// - calculate speed, pace, and distance
// - show summary

public abstract class Activity
{
    // Fields that stores activity name, date, duration, distance, speed, pace and activity type
    protected string _activityName;
    static DateTime dateNow = DateTime.Now;
    protected string _date = dateNow.ToString("d MMMM yyyy");
    protected int _activityLength;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected string _activityType;

    // A constructor that receives duration as parameter and stores it for local use
    public Activity(int activityLength)
    {
        _activityLength = activityLength;
        // acquires the type of activity and stores it in a field
        _activityType = GetType().Name;
    }

    // Methods that calculates the distance, speed and pace
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();

    // A method that calls the calculator methods and displays the summary
    public void GetSummary()
    {
        CalculateDistance();
        CalculateSpeed();
        CalculatePace();
        Console.WriteLine($"\n{_date} {_activityType} ({_activityLength}) min - Distance: {_distance.ToString("0.0")} miles, Speed: {_speed.ToString("0.00")} mph, Pace: {_pace.ToString("0.0")} min per mile");
    }
}