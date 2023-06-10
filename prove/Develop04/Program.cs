using System;
using System.Collections.Generic;

// STRETCH

class Program
{
    // Creates a set list for displaying menu options.
    static List<string> menuList = new List<string> {"Start breathing activity", "Start reflecting activity", "Start listing activity", "Summary log","Quit"};
    // Instantiates the LogManager class
    static LogManager logmanager = new LogManager();

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        DisplayMenu();
    }

    static void DisplayMenu()
    {
        // Initializes the user input to 0.
        int userChoice = 0;
        Console.Clear();

        //  A loop to continuously display the menu for the user.
        while (true)
        {
            Console.WriteLine("Menu Options:");

            // A loop that iterates through the List above to display in numbered format.
            for (int i = 0; i < menuList.Count; i++)
            {
                Console.WriteLine($"{i+1}. {menuList[i]}");
            }
        
            try
            {
                // Gets the user input.
                Console.Write("\nSelect a choice from the menu: ");
                userChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            // An error handler when the user inputs a letter and not a number.
            catch (FormatException)
            {
                Console.WriteLine("Invalid choice.\n");
            }

            // If conditions for each user choice from the menu which instantiates each sublass to perform their functionalities.
            // Also contains counters for each activities to use in the LogManager Class later.

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
                Console.Clear();
                // Calls the method to display the log options (display, save and load) for the user.
                logmanager.DisplayLogOptions();
                // A buffer to wait before the Menu options show up again which will clear the console after.
                string buffer = Console.ReadLine();
                Console.Clear();
            }

            // 5. QUIT
            if (userChoice == 5)
            {
                break;
            }

            // Displays message when user choice is out of 1-5 range.
            else if (userChoice > 5) 
            {
                Console.WriteLine($"Please choose numbers 1-5 only.\n");
            }
        }
    }
}