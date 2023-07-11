using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Foundation3 World!");


        Address lectureAddress = new Address("12St", "Corazon", "Japan");
        Lecture lecture = new Lecture("Lecture event", "lecturessss", "May 30", "7:00AM", lectureAddress, "John Bay", 39);
        Console.WriteLine("\n---------------LECTURE---------------");
        lecture.StandardDetails();
        lecture.FullDetails();
        lecture.ShortDescription();

        Address receptionAddress = new Address("12St", "Corazon", "Japan");
        string email = "We are cordially inviting you to the wedding reception of Jared and Camille";
        Reception reception = new Reception("Reception event", "reception", "May 30", "9:30AM", receptionAddress, email);
        Console.WriteLine("\n---------------RECEPTION---------------");
        reception.StandardDetails();
        reception.FullDetails();
        reception.ShortDescription();

        Address outdoorAddress = new Address("12St", "Corazon", "Japan");
        OutdoorGathering outdoor = new OutdoorGathering("outdoor event", "outdoor", "May 30", "6:45PM", outdoorAddress, "Sunny");
        Console.WriteLine("\n---------------OUTDOOR---------------");
        outdoor.StandardDetails();
        outdoor.FullDetails();
        outdoor.ShortDescription();
    }
}