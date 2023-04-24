using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Prep 2 - Conditionals");
        Console.WriteLine();

        Console.Write("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());

        // Type inputType = gradePercentage.GetType();
        // Console.WriteLine(inputType);

        string gradeEquivalent = null;

            if (gradePercentage >= 90)
            {
                gradeEquivalent = "A";
            }
            else if (gradePercentage >= 80)
            {
                gradeEquivalent = "B";
            }
            else if (gradePercentage >= 70)
            {
                gradeEquivalent = "C";
            }
            else if (gradePercentage >= 60)
            {
                gradeEquivalent = "D";
            }
            else if (gradePercentage < 60)
            {
                gradeEquivalent = "F";
            }

        int lastNumber = gradePercentage % 10;
        string plus = "+";
        string minus = "-";

            if (lastNumber >= 7)
            {
                gradeEquivalent += plus;
            }
                if (gradeEquivalent == "A+" || gradeEquivalent == "F+")
                {
                    gradeEquivalent = gradeEquivalent.Replace(plus, "");
                }  
            else if (lastNumber < 3)
            {
                gradeEquivalent += minus;
            }
                if (gradeEquivalent == "F-")
                {
                    gradeEquivalent = gradeEquivalent.Replace(minus, "");
                }

        Console.WriteLine($"Grade Equivalent: {gradeEquivalent}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Sorry, please try again.");
            Console.WriteLine();
        }
    }
}