using System;

// LECTURE CLASS
// Responsibilities:
// - store details for speaker and capacity
// - override full details

public class Reception : Event
{
    private string _rsvpEmail;

    // A constructor that receives parameters the same with the base class with the addition 
    // of RSVP email specific for this class, which then stores it for local use.
    public Reception(string eventTitle, string description, string date, string time, Address address, string email): base (eventTitle, description, date, time, address)
    {
        _rsvpEmail = email;
    }

    // Overrides base class's method to display event specific details.
    public override void FullDetails()
    {
        base.StandardDetails();
        Console.WriteLine($"RSVP:\"{_rsvpEmail}\"");
    }
}