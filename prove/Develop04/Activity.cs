using System;
using System.Collections.Generic;

// Activity Class
// - A class inherited by BreathingActivity, Reflecting Activity and ListingActivity Classes
// - Constructors are deemed unnecessary for this class.

// Responsibilities:
// - sets the fields and properties for complex functionalities of each subclasses' use.

public class Activity
{
    // Fields/properties that stores the activity name, description, and the instructions for each activity.
    protected string _activityName;
    protected string _description;
    protected string _instruction;
    protected string _endInstruction;  
    // A field/property that will store the chosen duration length of the user as int. 
    protected int _duration;
    // A field that stores the duration length for the number countdown or the spinner.
    protected int _countdown;
    // A field/property that stores the user input in string.
    protected string _userInput;
    // A field/property that stores the prompt for the subclasses to use and inherit.
    protected string _prompt;
    // A field that stores the added seconds from the start time
    protected DateTime _endTime;
    // A field that is not inherited by the random prompt from a list.
    private string _randomprompt;
    // A list uninherited by the subclasses to store the characters of the spinner
    private List<string> _spinnerList = new List<string>();
    // A list that checks if there are random prompts
    private List<string> _promptList = new List<string>();

    // A method that receives the countdown as a parameter and returns the end time.
    protected DateTime AddSeconds(int countdown)
    {
        // Stores the date/time into a field
        DateTime startTime = DateTime.Now;
        // Adds the countdown to the initial time and stores it in a field.
        DateTime endTime = startTime.AddSeconds(countdown);
        // Returns the final product
        return endTime;
    }

    // A method that shows the spinning effect as a buffer in the terminal
    protected void DisplaySpinner(int countdown)
    {
        // Adds the individual characters into the List
        _spinnerList.Add("|");
        _spinnerList.Add("/");
        _spinnerList.Add("-");
        _spinnerList.Add("\\");

        // Calls the method and passes the parameter then stores it.
        _endTime = AddSeconds(countdown);

        // Index indicator
        int i = 0;

        // A loop that would iterate through the list to display
        // according to the duration
        while (DateTime.Now < _endTime)
        {
            // Stores each string from the list according to its index
            string s = _spinnerList[i];
            // Displays the string
            Console.Write(s);
            // Pauses the program
            Thread.Sleep(600);
            // Erases and replaces the string
            Console.Write("\b \b");
            
            // Increments the index so it would go through the List
            i++;

            // A condition that resets the index to 0 if it has already reached the List's limit
            if (i >= _spinnerList.Count)
            {
                i = 0;
            }
        }
    }

    // A method that displays the instructions and receives a prompt as parameter.
    protected void DisplayInstructions(string prompt)
    {
        Console.Clear();
        // Displays the instructions and its prompt in a specified format
        Console.WriteLine($"{_instruction}:\n");
        Console.WriteLine($"---- {prompt} ----\n");
        Console.Write(_endInstruction);
    }

    // A method displays the start / welcome message for each activity in a specified format.
    protected void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity. \n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long (in seconds) would you like for your session? ");
        // Calls the method to get user input and converts it into int as a duration.
        _duration = int.Parse(GetUserInput());
        Console.Clear();
        Console.WriteLine("Get ready...");
        // Calls the method to display spinner which passes a value from a method. 
        DisplaySpinner(SpinnerDuration());
    }

    // A method congratulatory message with chosen duration with a specified format.
    protected void EndMessage()
    {
        Console.WriteLine("\nWell done!!\n");
        // Calls the method to display spinner which passes a value from a method. 
        DisplaySpinner(SpinnerDuration());
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity.");
        // Calls the method to display spinner which passes a value from a method. 
        DisplaySpinner(SpinnerDuration());
        Console.Clear();
    }

    // Methods to initially sets the countdown for the subclasses' use and also for the Start and EndMessage methods.
    protected int InitialCountdown()
    {
        _countdown = 5;
        return _countdown;
    }

    protected int SpinnerDuration()
    {
        _countdown = 10;
        return _countdown;
    }

    // A method that displays the number countdown and receives the duration as parameter.
    protected void NumberCountDown(int duration)
    {
        // Iterates through the duration and displays in increments and replaces each number as it goes through.
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // A method that reads from a file, receives the filename as a parameter and returns a list
    private List<string> ReadFile(string filename)
    {
        // Initializes a list to store the strings from the file.
        List<string> list = new List<string>();
        // Reads the file and converts it into a List then stores it.
        list = System.IO.File.ReadAllLines(filename).ToList();
        // Returns the list
        return list;
    }

    // A method that randomizes from a list (which it receives as a parameter) and returns a random prompt.
    private string RandomPrompt(List<string> list)
    {
        // Instantiates random and stores it in a variable.
        Random rnd = new Random();
        
        // Get a random line from the list
        _randomprompt = list[rnd.Next(list.Count)];
        
        // Returns the random line.
        return _randomprompt;
    }

    // A method that acquires the prompt and is used by the subclasses
    // Calls the local methods to perform their tasks and receives the 
    // filename as a parameter which then returns the prompt
    protected string GetPrompt(string filename)
    {
        // Instantiates a list and calls the local method to read from a file
        List<string> list = ReadFile(filename);
        // Calls the local method to randomize from the list
        string prompt = RandomPrompt(list);

        // Checks if there is a duplicate prompt which then calls
        // the local method again.
        if (_promptList.Contains(_prompt))
        {
            while(_promptList.Contains(_prompt))
            {
                prompt = RandomPrompt(list);
                break;
            }
            
        }
        // Adds the prompt to the list
        _promptList.Add(prompt);
        // Returns the randomized prompt
        return prompt;
    }

    // A method that gets the user input
    protected string GetUserInput()
    {
        _userInput = Console.ReadLine();
        return _userInput;
    }
}