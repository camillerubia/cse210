using System;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    protected int _countdown;
    private string randomprompt;
    protected string _instruction;
    protected string _userInput;

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
        return _countdown;
    }

    protected int InitialCountdown()
    {
        _countdown = 5;
        return _countdown;
    }

    protected string RandomPrompt(List<string> list)
    {
        return randomprompt;
    }

    protected void DisplayPrompt()
    {

    }

    protected void DisplayInstructions()
    {

    }

    protected string GetUserInput()
    {
        return _userInput;
    }

    protected void DisplaySpinner()
    {
        
    }

}