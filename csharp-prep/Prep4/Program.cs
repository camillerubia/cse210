using System.Collections.Generic;

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
            numbers.Add(userNumber);
        }

        Console.WriteLine(numbers);
    }
}