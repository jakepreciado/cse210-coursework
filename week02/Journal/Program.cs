using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome back to your Journal!\nPlease choose one of the following:");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");

        Journal journal = new Journal();
        Prompt prompt = new Prompt();
        int choice = 0;

        do
        {
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();
            choice = int.Parse(input);

            if (choice == 1)
            {
                string randomPrompt = prompt.GetRandomPrompt();
                Console.WriteLine($"{randomPrompt}");
                Console.Write("Journal entry: ");
                string entryText = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();

                Entry newEntry = new Entry
                {
                    _date = date,
                    _prompt = randomPrompt,
                    _entry = entryText
                };

                journal.AddEntry(newEntry);
                Console.WriteLine("Your journal entry has been added!\n");
            }

            else if (choice == 2)
            {
                journal.DisplayAllEntries();
            }

            else if (choice == 3)
            {
                Console.Write("Enter the file you would like to load: ");
                string fileName = Console.ReadLine();
                journal.Load(fileName);
                Console.WriteLine($"{fileName} has been loaded!\n");
            }
            else if (choice == 4)
            {
                Console.Write("Please enter a file name: ");
                string fileName = Console.ReadLine();
                journal.Save(fileName);
                Console.WriteLine("Your entries have been saved!\n");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Thanks for using the Journal Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid entry. Please try again.");
            }


        } while (choice != 5);
    }
}