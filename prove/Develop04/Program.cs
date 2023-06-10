using System;
using System.Collections.Generic;

class Program
{
    static List<string> menuList = new List<string> {"Start breathing activity", "Start reflecting activity", "Start listing activity", "Summary log","Quit"};
    static LogManager logmanager = new LogManager();
    static Activity activity = new Activity();

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

            // 1. BREATHING
            if (userChoice == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                logmanager._breathingCounter ++;
            }

             // 2. REFLECTING
            if (userChoice == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity();  
                logmanager._reflectingCounter ++;
            }

             // 3. LISTING
            if (userChoice == 3)
            {
                ListingActivity listing = new ListingActivity();  
                logmanager._listingCounter ++;    
            }

            // 4. SUMMARY
            if (userChoice == 4) 
            {
                logmanager.DisplayLogOptions();
                string input = activity.GetUserInput();
                Console.Clear();
            }

            // 5. QUIT
            if (userChoice == 5)
            {
                break;
            }

            // Displays message when user choice is out of 1-4 range.
            else if (userChoice > 5) 
            {
                Console.WriteLine($"Please choose numbers 1-4 only.\n");
            }
        }
    }
}