using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!!");
        // Console.Write("Testing Write");
        // Console.WriteLine("Testing WriteLine.");
        // Console.WriteLine("What is your name?");
        // string userName = Console.ReadLine();

        // Console.WriteLine($"Nice to meet you, {userName}!");
        
        // Console.WriteLine(userName.GetType());

        // int [] numbers = { 1, 2, 3 };
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }

        
        // Console.Write("First: ");
        // int number = int.Parse(Console.ReadLine());
        // Console.WriteLine(number);

        // Console.Write("Second: ");
        // number = int.Parse(Console.ReadLine());
        // Console.WriteLine(number);

        // string response = "yes";
        // while (response == "yes")
        // {
        //     Console.Write("Continue? ");
        //     response = Console.ReadLine();
        // }

        List<string> words = new List<string>() {"love", "independence", "stability"};

        // for (int i = 0; i < words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // }

        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(i);
        }

        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }

    }
}