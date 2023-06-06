using System;
using System.Collections.Generic;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    protected int _countdown;
    private string randomprompt;
    protected string _instruction;
    protected string _userInput;
    private List<string> _spinnerList = new List<string>();
    protected string _prompt;
    protected string _endInstruction;
    

    public Activity()
    {

    }

    protected void DisplaySpinner(int countdown)
    {
        _spinnerList.Add("\\");
        _spinnerList.Add("|");
        _spinnerList.Add("/");
        _spinnerList.Add("-");
    
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_countdown);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = _spinnerList[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= _spinnerList.Count)
            {
                i = 0;
            }
        }
    }

    protected void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity. \n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long (in seconds) would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        _countdown = 3;
        DisplaySpinner(_countdown);
    }

    protected int InitialCountdown()
    {
        _countdown = 5;
        return _countdown;
    }
    protected void EndMessage()
    {
        Console.WriteLine("Well done!!\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity.");
    }

    protected int GetCountDown()
    {
        return _countdown;
    }

    protected string RandomPrompt(List<string> list)
    {
        Random rnd = new Random();
        
        // Get a random line from the list
        randomprompt = list[rnd.Next(list.Count)];
        
        // Returns the random line.
        return randomprompt;
    }

    protected void DisplayInstructions(string prompt)
    {
        Console.WriteLine($"{_instruction}:\n");
        Console.WriteLine($"---- {prompt} ----\n");
        Console.WriteLine(_endInstruction);
    }

    protected List<string> ReadFile(string filename)
    {
        List<string> list = new List<string>();
        list = System.IO.File.ReadAllLines(filename).ToList();
        return list;
    }
    protected string GetUserInput()
    {
        return _userInput;
    }



}