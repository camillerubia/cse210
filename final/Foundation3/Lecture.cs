using System;

// LECTURE CLASS
// Responsibilities:
// - store details for speaker and capacity
// - override full details method

public class Lecture : Event
{
    // Fields for storing speaker and capacity
    private string _speaker;
    private int _capacity;

    // A constructor that receives parameters the same with the base class with the addition 
    // of speaker and capacity specific for this class, which then stores it for local use.
    public Lecture(string eventTitle, string description, string date, string time, Address address, string speaker, int capacity): base (eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Overrides base class's method to display event specific details.
    public override void FullDetails()
    {
        base.StandardDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}