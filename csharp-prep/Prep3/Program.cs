using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep 3 - Loops");

        string playAgain = "";

        while (playAgain == "yes")
        {
            Console.WriteLine();
            Console.WriteLine("Guess the magic number from 1-100.");

            Random randomizer = new Random();
            int randomNumber = randomizer.Next(1, 101);

            Console.WriteLine();
            Console.WriteLine($"What is the magic number? {randomNumber}");
            
            int userGuess = 0;
            int guessCounter = 1;

            while (userGuess != randomNumber)
            {
                Console.WriteLine();
                Console.WriteLine($"Guess #{guessCounter}");
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                guessCounter ++;

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
            Console.Write("Do you want to play again? (yes or no): ");
            playAgain = Console.ReadLine();
    }
}