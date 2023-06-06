using System;

public class BreathingActivity : Activity
{
    private int _inDuration;
    private int _outDuration;
    public BreathingActivity()
    {
        _activityName = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly."
                        +" Clear your mind and focus on your breathing.";
        StartMessage();
        DisplayBreathing(_duration);
        
        EndMessage();
    }

    private void DisplayBreathing(int duration)
    {
        _inDuration = duration / 2;
        Console.WriteLine(_inDuration);
    }
}