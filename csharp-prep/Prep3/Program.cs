using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep 3 - Loops");

        // Assign a positive value to playAgain for while loop. 
        string playAgain = "yes";

        // Loop begins
        while (playAgain == "yes")
        {
            Console.WriteLine();
            Console.WriteLine("Guess the magic number from 1-100.");

            // Calls the Random class and assigns to the randomizer variable 
            // when keyword new is initiated.
            Random randomizer = new Random();

            // Declares an int variable and assigns its value using the randomizer 
            // variable providing the start and ending range using Next method.
            int randomNumber = randomizer.Next(1, 101);

            // Shows the random number to the user.
            Console.WriteLine();
            Console.WriteLine($"What is the magic number? {randomNumber}");
            
            // Assigns a blank value to userGuess for the while loop.
            int userGuess = 0;

            // Assigns an initial 1 value to guessCounter variable.
            int guessCounter = 1;

            // Loop begins as long as the user's guess doesn't match with the 
            // randomized number.
            while (userGuess != randomNumber)
            {
                // Prints the guess number using the guessCounter variable.
                Console.WriteLine();
                Console.WriteLine($"Guess #{guessCounter}");

                // Asks the user's guess.
                Console.Write("What is your guess? ");

                // Converts the user input into an int and stores it in 
                // userGuess with an initial value of 0.
                userGuess = int.Parse(Console.ReadLine());

                // Increments the guessCounter value every time the loop
                // begins.
                guessCounter ++;

                // Checks if the userGuess is higher, lower or equal to the 
                // randomNumber and prints a message.
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
            // Asks for user confirmation if user wants to play again or not.
            // When user answers 'yes' the while loop in line 13 activates.
            // When user answers 'no', a message is shown.
            Console.WriteLine();
            Console.Write("Do you want to play again? (yes or no): ");
            playAgain = Console.ReadLine();

            // Message printed when user answers 'no'.
            Console.WriteLine("Thank you for playing!");
        }
    }
}