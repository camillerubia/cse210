using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Learning02 Activity");
        Console.WriteLine();

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        string jobTitle1 = job1._jobTitle;
        job1._company = "Microsoft";
        string company1 = job1._company;
        job1._startYear = 2019;
        int startYear1 = job1._startYear;
        job1._endYear = 2022;
        int endYear1 = job1._endYear;
        // job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._jobTitle = "Backend Developer";
        string jobTitle2 = job2._jobTitle;
        job2._company = "Apple";
        string company2 = job2._company;
        job2._startYear = 2022;
        int startYear2 = job2._startYear;
        job2._endYear = 2023;
        int endYear2 = job2._endYear;
        // job2.DisplayJobDetails(); 

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        string name = myResume._name;
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();

        // string firstJob = myResume._jobs[0]._jobTitle;
        // Console.WriteLine(firstJob);
    }
}