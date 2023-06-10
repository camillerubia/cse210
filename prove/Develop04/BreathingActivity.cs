using System;

// BreathingActivity Class
// - A class that inherits from Activity Class and uses most of its properties and methods.

// Responsibilities:
// - Displays the breathe in and breathe out activity

public class BreathingActivity : Activity
{
    // Field/Properties that stores the in and out duration
    private int _inDuration;
    private int _outDuration;
    // A field/property that determines how many batches of in and out should be there.
    private int _batchCounter;
    // A field/property that stores the last number of the duration
    private int _lastNumber;

    // Class constructor that sets the inherited properties specifically for the local class' usage and calls the
    // inherited and local methods.
    public BreathingActivity()
    {
        // Sets the inherited properties to local values.
        _activityName = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly."
                        +" Clear your mind and focus on your breathing.";
        // Calls the inherited method to display welcome message.
        StartMessage();
        // Calls the local method and passes the inherited method value
        ComputeDuration(InitialCountdown());
        // Calls the local method and passes in the inherited property value.
        ComputeDuration(_duration);
        // Calls the inherited method to display congratulatory message.
        EndMessage();
    }

    // A method that computes the duration and determines the batch count, then
    // calls the method to display the breathing exercises according to the duration
    private void ComputeDuration(int duration)
    {
        // Separates the duration if it's more than or equal to 10 and perform
        // specific functionalities in it.
        if (duration >= 10)
        {
            // Gets the last number and stores it
            _lastNumber = duration % 10;
            // Subtracts the last number from the original duration
            duration = duration - _lastNumber;

            // Checks if the duration is divisible by 10
            if (duration % 10 == 0)
            {
                // Determines how many batches would be there to display
                // and start the breathing exercies.
                _batchCounter = duration / 10;
                // Sets the duration to 10
                duration = 10;
                // Calls the method to start the breathing exercises and passes
                // the set duration and the batch counter
                DisplayBreathing(duration, _batchCounter);

                // Displays the remaining time for breathing exercises 
                if (_lastNumber > 0)
                {
                    // Sets the counter to 1
                    _batchCounter = 1;
                    // Calls the local method and passes in the last number
                    // and the batch count
                    DisplayBreathing(_lastNumber, _batchCounter);
                }  
            }            
        }
        // Separates the duration that are less than 10 and sets the batch count
        // to 1 then calls the method
        else
        {
            _batchCounter = 1;
            DisplayBreathing(duration, _batchCounter);
        }
    }

    // A method that computes the in and out duration, displays the breathing exercises
    // according to the duration and batch count received as parameters
    private void DisplayBreathing(int duration, int batchCount)
    {
        // Computes each in and out duration according to pre-determined duration parts 
        _inDuration = Convert.ToInt32(duration * 0.4);
        _outDuration = Convert.ToInt32(duration * 0.6);

        // Repeats the exercise according to the batch count then displays the countdowns
        for (int i = batchCount; i > 0; i--)
        {
            Console.Write("\nBreathe in... ");
            NumberCountDown(_inDuration);
            Console.Write("\nNow breathe out... ");
            NumberCountDown(_outDuration);
            Console.WriteLine();
        }
    }  
}