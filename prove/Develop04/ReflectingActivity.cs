using System;
using System.Collections.Generic;

public class ReflectingActivity: Activity
{
    private List<string> _reflectPromptList = new List<string>();
    private List<string> _questionList = new List<string>();
    private List<string> _randomQuestions = new List<string>();
    private string _question;
    private int _determiner;

    public ReflectingActivity()
    {
        _activityName = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _instruction = "Consider the following prompt";
        _endInstruction = "When you have something in mind, press enter to continue.";
        StartMessage();
        Reflection();
        DisplayFollowUp();
        DisplayQuestion();
        EndMessage();
    }

    private void Reflection()
    {
        Console.Clear();
        _reflectPromptList = ReadFile("reflectionPrompt.txt");
        _prompt = RandomPrompt(_reflectPromptList);
        DisplayInstructions(_prompt, true);
        GetUserInput();
    }

    private void DisplayFollowUp()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.\n You may begin in: ");
        GetNumCountDown(InitialCountdown());
    }
    private void DisplayQuestion()
    {
        Console.Clear();
        _questionList = ReadFile("questionPrompt.txt");
        _prompt = RandomPrompt(_questionList);
        _determiner = _duration / 2;

        for (int i = 2; i > 0; i--)
        {
            _prompt = RandomPrompt(_questionList);
            _randomQuestions.Add(_prompt);

            if (_randomQuestions.Contains(_prompt))
            {
                _prompt = RandomPrompt(_questionList);
            }
            Console.WriteLine($"> {_prompt}");
            DisplaySpinner(_determiner);
        }
    }
}