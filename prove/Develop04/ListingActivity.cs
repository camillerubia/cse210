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
        StartMessage();    
    }

    private List<string> GetListingInput()
    {
        return _inputList;
    }
}