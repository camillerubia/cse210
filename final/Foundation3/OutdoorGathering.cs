using System;

public class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string eventTitle, string description, string date, string time, Address address, string weatherStatement): base (eventTitle, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    public override void FullDetails()
    {
        base.StandardDetails();
        Console.WriteLine($"Weather: {_weatherStatement}");
    }
}