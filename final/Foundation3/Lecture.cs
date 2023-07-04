using System;

public class Lecture : Event
{
    private string speaker;
    private int _capacity;

    public Lecture(string eventTitle, string description, string date, string time, string address): base (eventTitle, description, date, time)
    {

    }
}