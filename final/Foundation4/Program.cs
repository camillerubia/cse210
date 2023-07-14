using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Foundation4 World!");
        // Create a list of activities
        List<Activity> activities = new List<Activity>();

        // Instantiate each activity and pass in required parameters then add to list
        Running run = new Running(30, 3);
        activities.Add(run);

        Cycling cycle = new Cycling(30, 10);
        activities.Add(cycle);

        Swimming swim = new Swimming(30, 5);
        activities.Add(swim);

        // Iterate through the list of activities and display summary
        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}