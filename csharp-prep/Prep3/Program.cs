using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep 3 - Loops");

        Random randomizer = new Random();
        int randomNumber = randomizer.Next(1, 11);

        Console.WriteLine();
        Console.WriteLine($"What is the magic number? {randomNumber}");
        Console.Write("What is your guess? ");
        int userGuess = int.Parse(Console.ReadLine());

        
            if (userGuess < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userGuess > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess == randomNumber)
            {
                Console.WriteLine("You guessed it!");
            }
    }
}