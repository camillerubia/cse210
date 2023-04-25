using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep 4 - Lists");
        Console.WriteLine();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        int userNumber = 1;
        List<int> numbers = new List<int> ();

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = numbers.Sum();
        double average = numbers.Average();
        int maxNumber = numbers.Max();

        Console.WriteLine();
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {maxNumber}");
        Console.WriteLine();
    }
}