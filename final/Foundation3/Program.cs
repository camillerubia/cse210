using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Foundation3 World!");

        // Create a list of events
        List<Event> events = new List<Event>();

        // Instantiates Address and Specific classes and passes in required parameters for each class.
        // Then adds them to the list of events
        // LECTURE
        Address lectureAddress = new Address("8742 Bert Unions", "Reston", "Massachusetts");
        Lecture lecture = new Lecture("Exploring the Depths of Knowledge", "A Journey to Intellectual Enlightenment", "January 8", "7:00 AM", lectureAddress, "John Bay", 39);
        events.Add(lecture);

        // RECEPTION
        Address receptionAddress = new Address("975 New Street", "Hemel", "Hempstead");
        string email = "We are cordially inviting you to the wedding reception of Jared and Camille";
        Reception reception = new Reception("Reception event", "For Time and All Eternity", "August 22", "9:30 AM", receptionAddress, email);
        events.Add(reception);

        // OUTDOOR
        Address outdoorAddress = new Address("83 Chemin Du Lavarin Sud", "Caen", "Basse-Normandie");
        OutdoorGathering outdoor = new OutdoorGathering("Nature's Symposium", "Embracing Wisdom under the Open Sky", "May 18", "1:45 PM", outdoorAddress, "Sunny");
        events.Add(outdoor);

        // Iterates through each events in the list and displays the Standard, Full and Short Details of each event
        foreach (var eventItem in events)
        {
            Console.WriteLine("**********************************\n");
            eventItem.StandardDetails();
            Console.WriteLine("---------------------------------\n");
            eventItem.FullDetails();
            Console.WriteLine("---------------------------------\n");
            eventItem.ShortDescription();
            Console.WriteLine("**********************************\n");
        }
    }
}