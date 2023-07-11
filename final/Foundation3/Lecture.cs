using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string eventTitle, string description, string date, string time, Address address, string speaker, int capacity): base (eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public Lecture(string speaker, int capacity)
    {
        
    }

    public override void FullDetails()
    {
        base.StandardDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}