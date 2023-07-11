using System;

public abstract class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _type;


    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = GetType().Name;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"\nEvent Title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date} | Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }

    public abstract void FullDetails();

    public void ShortDescription()
    {
        Console.WriteLine($"\nEvent Title: {_eventTitle} | Type: {_type}");
        Console.WriteLine($"Date: {_date} | Time: {_time}");
    }

}