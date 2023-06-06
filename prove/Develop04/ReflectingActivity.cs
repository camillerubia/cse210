using System;

public class ReflectingActivity: Activity
{
    private List<string> _reflectPromptList = new List<string>();
    private List<string> _questionList = new List<string>();

    public ReflectingActivity()
    {
        _activityName = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        StartMessage();
        EndMessage();
    }

    private void DisplayQuestion()
    {

    }
}