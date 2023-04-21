using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!!");
        Console.Write("Testing Write");
        Console.WriteLine("Testing WriteLine.");
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();

        Console.WriteLine($"Nice to meet you, {userName}!");
        
        Console.WriteLine(userName.GetType());
    }
}