using System;

public class BreathingActivity : Activity
{
    private int _inDuration;
    private int _outDuration;
    private int _batchCounter;
    private int _lastNumber;
    public BreathingActivity()
    {
        _activityName = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly."
                        +" Clear your mind and focus on your breathing.";
        StartMessage();
        ComputeDuration(InitialCountdown());
        ComputeDuration(_duration);
        EndMessage();
    }

    private void ComputeDuration(int duration)
    {
        if (duration >= 10)
        {
            _lastNumber = duration % 10;

            if (_lastNumber > 0)
                {
                    duration = duration /10 * 10;
                    _batchCounter = 1;
                    DisplayBreathing(_lastNumber);
                }

            if (duration % 10 == 0)
            {
                _batchCounter = duration / 10;
                duration = 10;
                DisplayBreathing(duration);   
            }            
        }
        else
        {
            _batchCounter = 1;
            DisplayBreathing(duration);
        }
    }

    private void DisplayBreathing(int duration)
    {
        _inDuration = Convert.ToInt32(duration * 0.4);
        _outDuration = Convert.ToInt32(duration * 0.6);

        for (int i = _batchCounter; i > 0; i--)
        {
            Console.Write("\nBreathe in... ");
            GetCountDown(_inDuration);
            Console.Write("\nNow breathe out... ");
            GetCountDown(_outDuration);
            Console.WriteLine();
        }
    }  
}