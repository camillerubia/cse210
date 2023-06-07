using System;

public class ReflectingActivity: Activity
{
    private List<string> _reflectPromptList = new List<string>();
    private List<string> _questionList = new List<string>();
    private string _question;

    public ReflectingActivity()
    {
        _activityName = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _instruction = "Consider the following prompt";
        _endInstruction = "When you have something in mind, press enter to continue.";
        _followUp = "Now ponder on each of the following questions as they related to this experience.\n You may begin in: ";
        StartMessage();
        Reflection();
        FollowUp();
        GetCountDown(5);
        DisplayQuestion();
        EndMessage();
    }

    private void Reflection()
    {
        _reflectPromptList = ReadFile("reflectionPrompt.txt");
        _prompt = RandomPrompt(_reflectPromptList);
        DisplayInstructions(_prompt, true);
        GetUserInput();
    }
    private void DisplayQuestion()
    {
        Console.Clear();
        _questionList = ReadFile("questionPrompt.txt");
        // _question = RandomPrompt(_questionList);
        foreach (string line in _questionList)
        {
            Console.WriteLine($"> {line}");
            DisplaySpinner(3);
        }
    }

    
}