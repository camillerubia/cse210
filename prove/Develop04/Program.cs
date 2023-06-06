using System;
using System.Collections.Generic;

class Program
{
    static List<string> menuList = new List<string> {"Start breathing activity", "Start reflecting activity", "Start listing activity", "Quit"};
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        DisplayMenu();
    }

    static void DisplayMenu()
    {
        int userChoice = 0;
        Console.Clear();
        
        while (true)
        {
            Console.WriteLine("Menu Options:");
            for (int i = 0; i < menuList.Count; i++)
            {
                Console.WriteLine($"{i+1}. {menuList[i]}");
            }
        
            try
            {
                Console.Write("\nSelect a choice from the menu: ");
                userChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            catch (FormatException)
            {
                Console.WriteLine("Invalid choice.\n");
            }

            if (userChoice == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                Console.WriteLine("Breathing Activity\n");
            }

            if (userChoice == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                Console.WriteLine("Reflecting Activity\n");
            }

            if (userChoice == 3)
            {
                ListingActivity listing = new ListingActivity();
                Console.WriteLine("Listing Activity\n");
            }

            // 4. QUIT
            if (userChoice == 4) 
            {
                break;
            } 

            // Displays message when user choice is out of 1-4 range.
            else if (userChoice > 4) 
            {
                Console.WriteLine($"Please choose numbers 1-4 only.\n");
            }

        }

    }
}