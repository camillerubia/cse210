using System;

public class Assignment
{
    protected string _studentName;
    protected string _topic;

    public Assignment (string name, string topic)
    {
        Console.Clear();
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    public string GetName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
}