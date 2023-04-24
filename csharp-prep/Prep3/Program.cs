using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep 3 - Loops");

        Random randomizer = new Random();
        int randomNumber = randomizer.Next(1, 11);

        Console.WriteLine($"What is the magic number? {randomNumber}");
    }
}