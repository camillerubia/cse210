using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string eventTitle, string description, string date, string time, Address address, string email): base (eventTitle, description, date, time, address)
    {
        _rsvpEmail = email;
    }

    public override void FullDetails()
    {
        base.StandardDetails();
        Console.WriteLine($"RSVP:\"{_rsvpEmail}\"");
    }
}