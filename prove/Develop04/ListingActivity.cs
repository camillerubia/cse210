using System;

public class ListingActivity : Activity
{
    private List<string> _listingQuestionsList = new List<string>();
    private List<string> _inputList = new List<string>();
    private int _itemCounter;

    public ListingActivity()
    {
        _activityName = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _instruction = "List as many responses you can to the following prompt";
        _endInstruction = "You may begin in: ";
        StartMessage();
        List();
        EndMessage();
    }

    private void List()
    {
        _listingQuestionsList = ReadFile("listingPrompt.txt");
        _prompt = RandomPrompt(_listingQuestionsList);
        DisplayInstructions(_prompt, false);
        GetNumCountDown(InitialCountdown());
        GetListingInput();
    }

    private List<string> GetListingInput()
    {
        Console.WriteLine();
        Console.Write("> ");
        string input = GetUserInput();
        _inputList.Add(input);
        // Thread.Sleep((int)(_determiner * 1000));
        return _inputList;
    }
}