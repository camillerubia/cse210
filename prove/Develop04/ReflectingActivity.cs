using System;
using System.Collections.Generic;

// ReflectingActivity Class
// - A class that inherits from Activity Class and uses most of its properties and methods.

// Responsibilities:
// - Displays a prompt and follow up questions according to user specified duration

public class ReflectingActivity: Activity
{
    private int _durationDeterminer;

    // Class constructor that sets the inherited properties specifically for the local class' usage and calls the
    // inherited and local methods.
    public ReflectingActivity()
    {
        // Sets the inherited properties to local values.
        _activityName = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _instruction = "Consider the following prompt";
        _endInstruction = "When you have something in mind, press enter to continue.";

        // Calls the inherited method to display welcome message.
        StartMessage();
        // Calls the local methods to perform their specific tasks.
        ReflectionPrompt();
        DisplayFollowUp();
        DisplayQuestion();
        // Calls the inherited method to display congratulatory message.
        EndMessage();
    }

    private void ReflectionPrompt()
    {
        Console.Clear();
        // Calls the inherited method and passes in the filename to get the prompt
        _prompt = GetPrompt("reflectionPrompt.txt");
        // Calls the inherited method to display the prompt with its specified format
        DisplayInstructions(_prompt);
        Console.WriteLine();
        // Calls the inherited method to get the user input.
        GetUserInput();
    }

    // A local method that displays the follow up instructions with the countdown.
    private void DisplayFollowUp()
    {
        Console.Write($"Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        // Calls the inherited method to display the number countdown passing the value of another
        // inherited method as a parameter
        NumberCountDown(InitialCountdown());
    }

    // A local variable that displays two random questions
    private void DisplayQuestion()
    {
        Console.Clear();
        // Divides the overall duration into two as the delay for each question
        _durationDeterminer = _duration / 2;

        // Displays questions twice and calling a method as a buffer or delay
        for (int i = 2; i > 0; i--)
        {
            // Calls the inherited method to acquire a question prompt from the provided file
            _prompt = GetPrompt("questionPrompt.txt");
            // Displays the prompt questions in a specified format
            Console.WriteLine($"> {_prompt}");
            // Calls the inherited method as a buffer for each question
            DisplaySpinner(_durationDeterminer);
        }
    }
}