using System;

public class Person
 // A code template for the category of things known as Person. The
// responsibility of a Person is to hold and display personal information.
{
    // The C# convention is to start member variables with an underscore _
    public string _givenName = "";
    public string _familyName = "";

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Person()
    {
    }

    // A method that displays the person's full name as used in eastern 
    // countries or <family name, given name>.
    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName}, {_givenName}");
    }

    // A method that displays the person's full name as used in western 
    // countries or <given name family name>.
    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName} {_familyName}");
    }
}

public class Names
{
    public string _nameCollection  = " ";
    public List<Person> _people = new List<Person>();
}

class Program
{
    static void Main(string[] args)
    {
   
        Person person = new Person();
        person._givenName = "Joseph";
        person._familyName = "Smith";

        Person anotherPerson = new Person();
        anotherPerson._givenName = "Hyrum";
        anotherPerson._familyName = "Smith";

        Names smithFamily = new Names();
        smithFamily._nameCollection = "Smith Family Tree";
        smithFamily._people.Add(person);
        smithFamily._people.Add(anotherPerson);
        smithFamily._people[0].ShowWesternName();
        smithFamily._people[1].ShowWesternName();
        Console.WriteLine();

        foreach (Person p in smithFamily._people)
        {
            Console.WriteLine($"Name: {p._givenName} {p._familyName}");
            p.ShowEasternName();
            p.ShowWesternName();
        }
    }
}