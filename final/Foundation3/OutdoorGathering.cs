using System;

// OUTDOORGATHERING CLASS
// Responsibilities:
// - store details for weather statement
// - override full details method

public class OutdoorGathering : Event
{
    // A field that stores weather statement
    private string _weatherStatement;

    // A constructor that receives parameters the same with the base class with the addition 
    // of weather statement specific for this class, which then stores it for local use.
    public OutdoorGathering(string eventTitle, string description, string date, string time, Address address, string weatherStatement): base (eventTitle, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    // Overrides base class's method to display event specific details.
    public override void FullDetails()
    {
        base.StandardDetails();
        Console.WriteLine($"Weather: {_weatherStatement}");
    }
}