using System;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    private int countdown;
    private string randomprompt;

    public Activity()
    {
        
    }

    protected void StartMessage()
    {

    }

    protected void EndMessage()
    {

    }

    protected int GetCountDown()
    {
        return countdown;
    }

    protected int InitialCountdown()
    {
        countdown = 5;
        return countdown;
    }

    protected string RandomPrompt(List<string> list)
    {
        return randomprompt;
    }

    protected void DisplayPrompt()
    {

    }

}