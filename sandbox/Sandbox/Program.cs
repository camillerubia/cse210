using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!!");
        Console.Write("Testing Write");
        Console.WriteLine("Testing WriteLine.");
        Console.WriteLine("What is your name?");
        string user_input_name = Console.ReadLine();

        Console.WriteLine($"Nice to meet you, {user_input_name}!");
        
    }
}