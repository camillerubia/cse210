using System;

// EVENT CLASS
// Responsibilities:
// - stores event title, description, date, time, address and event type
// - displays standard and short details of each event
// - has full details to override in subclasses
public abstract class Event
{
    // Fields to store title, description, date, time, address and type
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _type;

    // A constructor that receives title, description, date, time, address and type as parameters
    // then stores it for local use.
    // Initiates the type of event 
    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = GetType().Name;
    }

    // A method that displays Standard Details for each event
    public void StandardDetails()
    {
        Console.WriteLine($"Event Title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date} | Time: {_time}");
        Console.WriteLine($"Address: {_address.GetAddress()}");
    }

    // A method that will be overridden by subclasses for their specific details
    public abstract void FullDetails();

    // A method that displays short description of each event
    public void ShortDescription()
    {
        Console.WriteLine($"Event Title: {_eventTitle} | Type: {_type}");
        Console.WriteLine($"Date: {_date} | Time: {_time}");
    }
}