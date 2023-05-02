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
        job1._startYear = 2001;
        int startYear1 = job1._startYear;
        job1._endYear = 2010;
        int endYear1 = job1._endYear;
        Console.WriteLine(company1);

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        string jobTitle2 = job2._jobTitle;
        job2._company = "Apple";
        string company2 = job2._company;
        job2._startYear = 2010;
        int startYear2 = job2._startYear;
        job2._endYear = 2017;
        int endYear2 = job2._endYear;
        Console.WriteLine(company2);

    }
}