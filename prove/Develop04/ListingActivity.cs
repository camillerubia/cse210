using System;
using System.Collections.Generic;
using System.Threading;

// ListingActivity Class
// - A class that inherits from Activity Class and uses most of its properties and methods.

// Responsibilities:
// - Displays a question and acquires user input according to time limit

public class ListingActivity : Activity
{
    // A list that stores all of the user input
    private List<string> _inputList = new List<string>();
    // A field/property that counts all items in a list
    private int _itemCounter;

    // Class constructor that sets the inherited properties specifically for the local class' usage and calls the
    // inherited and local methods.
    public ListingActivity()
    {
        // Sets the inherited properties to local values.
        _activityName = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _instruction = "List as many responses you can to the following prompt";
        _endInstruction = "You may begin in: ";

         // Calls the inherited method to display welcome message.
        StartMessage();
        // Calls the local methods to perform their specific tasks.
        QuestionGenerator();
        ListingInput();
        // Calls the inherited method to display congratulatory message.
        EndMessage();
    }

    // A local method that acquires random question and displays the countdown
    private void QuestionGenerator()
    {
        // Calls the inherited method and passes in the filename to get the prompt
        _prompt = GetPrompt("listingPrompt.txt");
        // Calls the inherited method to display the prompt with its specified format
        DisplayInstructions(_prompt);
        // Calls the inherited method to display the number countdown passing the value of another
        // inherited method as a parameter
        NumberCountDown(InitialCountdown());
    }

    // A local method that acquires user input according to time limit and counts all items
    private void ListingInput()
    {
        // Resets the user input
        string input = "";
        // Calls the inherited method and passes the duration and stores it in a field
        _endTime = AddSeconds(_duration);
        Console.WriteLine();
        
        // A loop that will serve as a time limit for the user input with a specified format
        while (DateTime.Now < _endTime)
        {
            Console.Write("> ");
            // Calls the inherited method to acquire the user input
            input = GetUserInput();
            // Adds the input to a list
            _inputList.Add(input);
        }

        // Counts all items in the list and stores it in a field
        _itemCounter = _inputList.Count;
        // Displays the total items with a specified format
        Console.WriteLine($"\nYou listed {_itemCounter} items!");
    }
}