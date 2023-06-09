using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _listingQuestionsList = new List<string>();
    private List<string> _inputList = new List<string>();
    private int _itemCounter;
    private bool _getUserInputRunning = true;

    public ListingActivity()
    {
        _activityName = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _instruction = "List as many responses you can to the following prompt";
        _endInstruction = "You may begin in: ";
        StartMessage();
        QuestionGenerator();
        ListingInput();
        EndMessage();
    }

    private void QuestionGenerator()
    {
        _listingQuestionsList = ReadFile("listingPrompt.txt");
        _prompt = RandomPrompt(_listingQuestionsList);
        DisplayInstructions(_prompt, false);
        GetNumCountDown(InitialCountdown());
    }

    private void ListingInput()
    {
        string input = "";

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine();
        
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            input = GetUserInput();
            _inputList.Add(input);
        }
        _itemCounter = _inputList.Count();

        Console.WriteLine($"You listed {_itemCounter} items!");
    }

}