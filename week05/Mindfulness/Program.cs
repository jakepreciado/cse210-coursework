using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\nWelcome to the Mindfulness Program. You are one step closer to a better you.");
        Console.WriteLine("\n--- MENU ---");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");

        while (true)
        {
            Console.Write("Select an exercise from the menu: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (input == "2")
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.Run();
            }
            else if (input == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (input == "4")
            {
                Console.WriteLine("\nWe'll see you next time! Take care.");
                break;
            }
            else
            {
                Console.WriteLine("\nSorry... I didn't quite catch that.");
            }
        }


    }
}