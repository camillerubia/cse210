using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep 4 - Lists");
        Console.WriteLine();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        // Set an initial value for userNumber as an identifier in the while loop.
        int userNumber = 1;

        // Creates an int list for storing user input numbers.
        List<int> numbers = new List<int> ();

        // Loops the program until user inputs 0.
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");

            // Converts the user input from string to int.
            userNumber = int.Parse(Console.ReadLine());

            // Stores user input numbers that are not 0.
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Stores the sum, average, max and min numbers in a variable from the created list.
        int sum = numbers.Sum();
        double average = numbers.Average();
        int maxNumber = numbers.Max();

        // Identifies and returns positive numbers from the list using Lambda function
        // that separates it from the negative numbers and stores it in a new list.
        List<int> posNum = numbers.Where(n => n > 0).ToList();
        int minPosNumber = posNum.Min();

        // Sorts the created number list.
        numbers.Sort();

        // Prints the results. - Core Requirements
        Console.WriteLine();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.WriteLine();

        // Prints Stretch results.
        Console.WriteLine($"The smallest positive number is: {minPosNumber}");
        Console.WriteLine("The sorted list is:");

        // Iterates and prints the sorted list.
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}